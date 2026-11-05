using System.Collections.Generic;
using UnityEngine;

public class InteractExample : MonoBehaviour
{
    private List<IInteractable> _interactables = new List<IInteractable>();
    public Lock chestLock = new Lock();
    public Lock doorLock = new Lock();
    public Wallet _wallet = new Wallet();
    public Trap _trap;
    
    private void Start()
    {
        _interactables.Add(new Lever());
        _interactables.Add(new Chest(chestLock, _wallet));
        _interactables.Add(new Door());
        _interactables.Add(new LockedDoor(doorLock));
        _interactables.Add(new Trap(_wallet));
        
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
