using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private SpriteRenderer enemySprite;
    [SerializeField] private EnemyModel enemyModel;

    private void Awake()
    {
        enemySprite = GetComponent<SpriteRenderer>();
        enemySprite.sprite = enemyModel.Sprite;
    }
}
