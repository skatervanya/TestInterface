using System.Collections.Generic;
using UnityEngine;

public class InteractExample : MonoBehaviour
{
    private List<IInteractable> _interactables = new List<IInteractable>();
    public Lock chestLock = new Lock();
    public Wallet _wallet = new Wallet();
    
    private void Start()
    {
        _interactables.Add(new Lever());
        _interactables.Add(new Chest(chestLock, _wallet));
        _interactables.Add(new Door());
        
        for (int i = 0; i < 3; i++)
        {
            foreach (IInteractable interactable in _interactables)
            {
                interactable.Interact();
            }
            
            if(i == 0)
                chestLock.Unlock(); 
        }
        
        Debug.Log($"We found {_wallet.Coins} coins");
    }
}
