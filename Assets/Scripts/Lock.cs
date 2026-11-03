public class Lock
{
    public bool IsLocked { get; private set; } = true;

    public void Unlock()
    {
        IsLocked = false;
    }
}
