public class ReactiveStateContainer
{
    private string? _savedString;

    public string Property
    {
        get => _savedString ?? string.Empty;
        set
        {
            _savedString = value;
            NotifyStateChanged();
        }
    }

    public event Action? OnChange;

    private void NotifyStateChanged() => OnChange?.Invoke();
}
