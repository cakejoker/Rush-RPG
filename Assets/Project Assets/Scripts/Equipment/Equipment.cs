using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Equipment", menuName = "Scriptable Object/Equipment", order = int.MaxValue)]
public class Equipment : ScriptableObject
{
    [SerializeField] Weapon _equipWeapon;
    public Weapon EquipWeapon
    {
        get { return _equipWeapon; }
        set { _equipWeapon = value; }
    }

    [SerializeField] Helmet _equipHelmet;
    public Helmet EquipHelmet
    {
        get { return _equipHelmet; }
        set { _equipHelmet = value; }
    }

    [SerializeField] Armor _equipArmor;
    public Armor EquipArmor
    {
        get { return _equipArmor; }
        set { _equipArmor = value; }
    }

    [SerializeField] Glove _equipGlove;
    public Glove EquipGlove
    {
        get { return _equipGlove; }
        set { _equipGlove = value; }
    }

    [SerializeField] Boots _equipBoots;
    public Boots EquipBoots
    {
        get { return _equipBoots; }
        set { _equipBoots = value; }
    }

    public Accessory[] EquipAccessorys = new Accessory[5];
}
