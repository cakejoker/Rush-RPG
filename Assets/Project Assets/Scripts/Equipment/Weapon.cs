using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapon", menuName = "Scriptable Object/Weapon Data", order = int.MaxValue)]
public class Weapon : ItemData
{
    [SerializeField] float _multiply;
    public float Multiply
    {
        get { return _multiply; }
        set { _multiply = value; }
    }

    [SerializeField] int _attack;
    public int Attack
    {
        get { return _attack; }
        set { _attack = value; }
    }
    
}
