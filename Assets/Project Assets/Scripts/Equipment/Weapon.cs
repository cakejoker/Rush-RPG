using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapon", menuName = "Scriptable Object/Weapon Data", order = int.MaxValue)]
public class Weapon : ItemData
{
    [SerializeField] float _atkMultiply;
    public float ATKMultiply
    { get { return _atkMultiply; } }

    [SerializeField] int _attack;
    public int Attack
    { get { return _attack; } }
}
