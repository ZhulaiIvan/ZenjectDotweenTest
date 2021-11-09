using System;
using DG.Tweening;
using UnityEngine;
using Zenject;

public class Enemy : MonoBehaviour
{
    private Player _player;
    private int _damage = 10;
    
    [Inject]
    private void Construct(Player player)
    {
        _player = player;
    }

    private void Start()
    {
        transform.DOMove(_player.transform.position, 2);
    }

    private void OnMouseDown()
    {
        _player.playerHit?.Invoke(10);
    }
}