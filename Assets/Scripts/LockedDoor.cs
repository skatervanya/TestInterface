using UnityEngine;

public class LockedDoor : IInteractable
{
    public string Name => "Locked Door";

    private Lock _lock;
    
    private bool _isOpen = false;

    public LockedDoor (Lock doorLock)
    {
        _lock = doorLock;
    }

    public void Interact()
    {
        if (_lock.IsLocked)
        {
            Debug.Log($"{Name} is locked");
        }
        else
        {
            _isOpen = !_isOpen;
            Debug.Log($"{Name} is {(_isOpen ? "open" : "closed")}");
        }
    }
}
