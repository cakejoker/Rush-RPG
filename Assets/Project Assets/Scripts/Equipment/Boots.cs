using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Boots", menuName = "Scriptable Object/Boots Data", order = int.MaxValue)]
public class Boots : ItemData
{
    [SerializeField] int _def;
    public int DEF { get { return _def; } }

    [SerializeField] float _speed;
    public float Speed { get { return _speed; } }
}
