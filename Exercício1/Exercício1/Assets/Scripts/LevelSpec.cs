using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "LevelSpec")] // Aparece no menu *Assets*
public class LevelSpec : ScriptableObject // Estende ScriptableObject
{
    [SerializeField] private Vector3[] enemySpawnPoints = null;

    public IEnumerable<Vector3> EnemySpawnPoints => enemySpawnPoints;
}
