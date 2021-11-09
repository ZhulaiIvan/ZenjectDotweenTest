using System;
using UnityEngine;


public class Player : MonoBehaviour
{
    [SerializeField] private int _health = 100;

    public int Health
    {
        get => _health;
        set
        {
            _health = value;
            if (_health <= 0)
                playerDead?.Invoke();
        }
    }

    public Action<int> playerHit;
    public Action playerDead;

    private void Awake()
    {
        playerHit += PlayerHit;
        playerDead += PlayerDead;
    }

    private void PlayerDead()
    {
        Debug.Log($"Player is dead {Health}");
    }

    private void PlayerHit(int damage)
    {
        Health -= damage;
    }
}