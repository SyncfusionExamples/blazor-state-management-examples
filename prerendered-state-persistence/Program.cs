//other code

builder.Services.AddSingleton<
    PersistentComponentStateSerializer<WeatherForecast[]>,
    EncryptedWeatherForecastSerializer>();

//other code
