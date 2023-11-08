using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Monster", menuName = "Scriptable Object/Monster Data", order = int.MaxValue)]
public class MonsterData : ScriptableObject
{
    [SerializeField] Sprite _monsterImage;
    public Sprite MonsterImage { get { return _monsterImage; } }

    [SerializeField] int _maxHP;
    public int MaxHP { get { return _maxHP; } }

    [SerializeField] int _atk;
    public int ATK { get { return _atk; } }

    [SerializeField] int _exp;
    public int EXP { get { return _exp; } }

    [SerializeField] int _gold;
    public int Gold { get { return _gold; } }

    [SerializeField] ItemData[] _dropList;
    public ItemData[] DropList { get { return _dropList; } }

    [SerializeField] int _currentHP;
    public int CurrentHP 
    { 
        get { return _currentHP; } 
        set { _currentHP = value; }
    }

    public ItemData SetDropItem()
    {
        int rand;
        bool isNewItem = false;
        rand = Random.Range(0, _dropList.Length);
        while (!isNewItem)
        { 
            if (!_dropList[rand].HasItem)
                isNewItem = true;
            else
                rand = Random.Range(0, _dropList.Length);
        }
        return _dropList[rand];
    }


}