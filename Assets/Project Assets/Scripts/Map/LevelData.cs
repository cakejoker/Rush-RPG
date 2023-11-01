using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelData : MonoBehaviour
{
    public GameObject[] SpawnList;
    public int Level;
    
    public GameObject SetSpawnMonster()
    {
        int rand = Random.Range(0, SpawnList.Length);
        return SpawnList[rand];
    }
}
