using UnityEngine;

public class Door : IInteractable
{
    private bool _isOpen = false;
    public string Name => "Door";
    
    public void Interact()
    {
        _isOpen = !_isOpen;
        Debug.Log($"{Name} is {(_isOpen ? "open" : "closed")}");
    }
}
