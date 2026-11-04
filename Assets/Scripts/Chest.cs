using UnityEngine;

public class Chest : IInteractable
{
    private Lock _lock;
    private Wallet _wallet;
    private int _coins = 10; 
    public string Name => "Chest";

    public Chest(Lock chestLock, Wallet wallet)
    {
        _lock = chestLock;
        _wallet = wallet;
    }
    
    public void Interact()
    {
        if(_lock.IsLocked)
            Debug.Log("Chest is locked");
        else if (_coins == 0)
            Debug.Log("Chest empty");
        else
        {
            _wallet.AddCoins(_coins);
            Debug.Log($"We found {_coins} coins");
            _coins = 0;
        }
    }
}

