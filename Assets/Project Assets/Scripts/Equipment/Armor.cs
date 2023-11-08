using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Armor", menuName = "Scriptable Object/Armor Data", order = int.MaxValue)]
public class Armor : ItemData
{
    [SerializeField] int _def;
    public int DEF { get { return _def; } }

    [SerializeField] float _defMultiply;
    public float DEFMultiply { get { return _defMultiply; } }
}
