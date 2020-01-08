using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "EnemyModel")]
public class EnemyModel : ScriptableObject
{

    [SerializeField]private Sprite _sprite;
    public Sprite Sprite => _sprite;
}
