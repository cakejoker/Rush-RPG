using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemList", menuName = "Scriptable Object/Item List", order = int.MaxValue)]
public class ItemList : ScriptableObject 
{
    public List<Weapon> _weaponList;
    public List<Helmet> _helmetList;
    public List<Armor> _armorList;
    public List<Glove> _gloveList;
    public List<Boots> _bootsList;
    public List<Accessory> _accessoryList;
}
