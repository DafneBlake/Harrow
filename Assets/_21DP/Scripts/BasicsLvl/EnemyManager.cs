using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyManager : MonoBehaviour
{
    public Transform player;
    public static Transform _player;

    public int avaliableEnemies;
    public static int _avaliableEnemies;

    private void Start()
    {
        _player = player;
        _avaliableEnemies = avaliableEnemies;
    }
}
