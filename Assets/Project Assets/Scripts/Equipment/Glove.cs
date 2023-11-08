using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Glove", menuName = "Scriptable Object/Glove Data", order = int.MaxValue)]
public class Glove : ItemData
{
    [SerializeField] int _def;
    public int DEF { get { return _def; } }
}
