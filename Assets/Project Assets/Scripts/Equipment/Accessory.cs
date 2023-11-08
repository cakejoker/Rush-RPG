using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Accessory", menuName = "Scriptable Object/Accessory Data", order = int.MaxValue)]
public class Accessory : ItemData
{
    [SerializeField] string _itemEffect;
    public string ItemEffect { get { return _itemEffect; } }
}
