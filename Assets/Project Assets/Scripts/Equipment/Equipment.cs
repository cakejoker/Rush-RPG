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
}
