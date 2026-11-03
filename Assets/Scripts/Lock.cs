using UnityEngine;

public class Lock : MonoBehaviour
{
    private bool _isLocked = true;

    public bool Unlock()
    {
        _isLocked = !_isLocked;

        return _isLocked;
    }
}
