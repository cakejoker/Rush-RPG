using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterData : MonoBehaviour
{
    public int _maxHp;
    public int _atk;
    public int _exp;
    public int _gold;
    public ItemData[] _dropList;

    public int _currentHp;

    public ItemData SetDropItem()
    {
        int rand = Random.Range(0, _dropList.Length);
        return _dropList[rand];
    }


}
