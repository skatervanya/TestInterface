using System.Collections.Generic;
using UnityEngine;

public class InteractExample : MonoBehaviour
{
    private List<IInteractable> _interactables = new List<IInteractable>();
    
    private void Start()
    {
        _interactables.Add(new Lever());
        _interactables.Add(new Chest());
        _interactables.Add(new Door());
        
        for (int i = 0; i < 3; i++)
        {
            foreach (IInteractable interactable in _interactables)
            {
                interactable.Interact();
            }
        }
    }
}
