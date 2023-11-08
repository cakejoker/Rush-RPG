using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment : MonoBehaviour
{
    Weapon _equipWeapon;
    public Weapon EquipWeapon
    {
        get { return _equipWeapon; }
        set { _equipWeapon = value; }
    }

    Helmet _equipHelmet;
    public Helmet EquipHelmet
    {
        get { return _equipHelmet; }
        set { _equipHelmet = value; }
    }

    Armor _equipArmor;
    public Armor EquipArmor
    {
        get { return _equipArmor; }
        set { _equipArmor = value; }
    }

    Glove _equipGlove;
    public Glove EquipGlove
    {
        get { return _equipGlove; }
        set { _equipGlove = value; }
    }

    Boots _equipBoots;
    public Boots EquipBoots
    {
        get { return _equipBoots; }
        set { _equipBoots = value; }
    }

    public Accessory[] EquipAccessorys = new Accessory[5];
}
