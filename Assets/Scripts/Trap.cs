using UnityEngine;

public class Trap : IInteractable
{
    private int _lostCoins = 3;
    public string Name => "Trap";
    private Wallet _wallet;

    public Trap(Wallet wallet)
    {
        _wallet = wallet;
    }
    
    public void Interact()
    {
        if (_wallet.TrySpend(_lostCoins))
        {
            Debug.Log($"Trap: lost {_lostCoins} coins, left {_wallet.Coins} coins");
        }
        else
        {
            Debug.Log($"Trap: not enough coins, trap is harmless");
        }
    }
}
