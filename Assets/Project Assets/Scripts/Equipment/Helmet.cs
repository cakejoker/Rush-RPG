using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Helmet", menuName = "Scriptable Object/Helmet Data", order = int.MaxValue)]
public class Helmet : ItemData
{
    [SerializeField] int _hp;
    public int HP { get { return _hp; } }

    [SerializeField] int _def;
    public int DEF { get { return _def; } }
}
