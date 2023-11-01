using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemList", menuName = "Scriptable Object/Item List", order = int.MaxValue)]
public class ItemList : ScriptableObject 
{
    [SerializeField] List<Weapon> _weaponList;
    //[SerializeField] List<Helmet> _helmetList;
    //[SerializeField] List<Armor> _armorList;
    //[SerializeField] List<Leggings> _leggingsList;
    //[SerializeField] List<Boots> _bootsList;
    //[SerializeField] List<Accessory> _accessoryList;
}
