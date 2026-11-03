using UnityEngine;

public class Chest : IInteractable
{
    public string Name => "Chest";
    public void Interact()
    {
        Debug.Log($"I am {Name}");
    } 
}

