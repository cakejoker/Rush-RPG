using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemData : ScriptableObject
{
    public enum ItemTypes
    {
        Weapon,
        Helmet,
        Armor,
        Glove,
        Boots,
        Accessory
    }

    [SerializeField] string _itemName;
    public string ItemName { get { return _itemName; } }

    [SerializeField] int _itemID;
    public int ItemID { get { return _itemID; } }

    [SerializeField] Sprite _itemImage;
    public Sprite ItemImage { get { return _itemImage; } }

    [SerializeField] ItemTypes _itemType;
    public ItemTypes ItemType { get { return _itemType; } }

    [SerializeField] bool _hasItem;
    public bool HasItem 
    { 
        get { return _hasItem; } 
        set { _hasItem = value; }
    }
}
