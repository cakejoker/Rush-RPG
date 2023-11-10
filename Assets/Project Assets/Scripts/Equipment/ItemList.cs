using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemList", menuName = "Scriptable Object/Item List", order = int.MaxValue)]
public class ItemList : ScriptableObject
{
    public List<Weapon> WeaponList;
    public List<Helmet> HelmetList;
    public List<Armor> ArmorList;
    public List<Glove> GloveList;
    public List<Boots> BootsList;
    public List<Accessory> AccessoryList;
}
