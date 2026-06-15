namespace StateManagement.Server.Services
{
    using Microsoft.AspNetCore.Components;
    using StateManagement.Server.Models;
    using System.Buffers;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.Json;

    public class EncryptedWeatherForecastSerializer
        : PersistentComponentStateSerializer<WeatherForecast[]>
    {
        // In production: Read from IConfiguration / Key Vault / Environment Variable
        private static readonly byte[] EncryptionKey =
            Encoding.UTF8.GetBytes("ThisIsExactly32BytesLongKey12345"); // Must be 32 bytes

        private static readonly JsonSerializerOptions _options = new()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        // DTO - Only what we want to persist (TemperatureF is completely excluded)
        private record Dto(
            DateOnly Date,
            string EncryptedTempC,   // ← Only this is encrypted
            string? Summary
        );

        public override void Persist(WeatherForecast[] value, IBufferWriter<byte> writer)
        {
            Console.WriteLine("=== CUSTOM SERIALIZER Persist() CALLED ===");

            var dtoArray = value.Select(f => new Dto(
                f.Date,
                Encrypt(f.TemperatureC),
                f.Summary
            )).ToArray();

            using var utf8Writer = new Utf8JsonWriter(writer);
            JsonSerializer.Serialize(utf8Writer, dtoArray, _options);
        }

        public override WeatherForecast[] Restore(ReadOnlySequence<byte> data)
        {
            Console.WriteLine("=== CUSTOM SERIALIZER Restore() CALLED ===");

            var reader = new Utf8JsonReader(data);
            var dtoArray = JsonSerializer.Deserialize<Dto[]>(ref reader, _options) ?? Array.Empty<Dto>();

            return dtoArray.Select(d => new WeatherForecast
            {
                Date = d.Date,
                TemperatureC = Decrypt(d.EncryptedTempC),
                Summary = d.Summary
            }).ToArray();
        }

        // ENCRYPTION HELPERS
        private static string Encrypt(int value)
        {
            //your encryption logic like AesGcm 

            return Convert.ToBase64String(encryptedValue);
        }

        private static int Decrypt(string base64Encrypted)
        {
            //your decryption logic like AesGcm 

            return BitConverter.ToInt32(plainBytes, 0);
        }
    }
}
