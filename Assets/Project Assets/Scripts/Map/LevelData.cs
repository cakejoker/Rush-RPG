using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelData : MonoBehaviour
{
    public MonsterData[] SpawnList;
    public int Level;
    
    public MonsterData SetSpawnMonster()
    {
        int rand = Random.Range(0, SpawnList.Length);
        return SpawnList[rand];
    }
}
