using UnityEngine;

public class Lever : IInteractable
{
    public string Name => "Lever";
    private int counter;
    public void Interact()
    {
        counter++;
        Debug.Log($"{Name} interact {counter}");
    }
}
