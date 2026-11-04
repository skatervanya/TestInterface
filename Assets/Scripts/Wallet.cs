using UnityEngine;

public class Wallet
{
    public int Coins { get; private set; } 

    public void AddCoins(int amount)
    {
        Coins += amount;
    }

    public bool TrySpend(int amount)
    {
        if (Coins < amount)
        {
            return false;
        }
        
        Coins -= amount;
        return true;
    }
}
