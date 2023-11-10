using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSelect : MonoBehaviour,IPointerClickHandler
{
    [SerializeField] UIManager _UIManager;
    // [SerializeField] Player _player;

    private void Start()
    {
        _UIManager = GameObject.Find("UIManager").GetComponent<UIManager>();
        //_player = GameObject.Find("Character").GetComponent<Player>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (_UIManager.IsItemEquip)
        {
            GameObject target = eventData.pointerPressRaycast.gameObject.transform.parent.gameObject;
            ItemList items = GameManager.Instance.ItemLists;
            int index = target.transform.GetSiblingIndex();
            switch (target.name)
            {
                case "Weapon ItemSlot":
                    if (items.WeaponList[index].HasItem)
                    {
                        _UIManager.EquipItem(items.WeaponList[index]);
                        _UIManager.CloseItemMenu();
                        _UIManager.IsItemEquip = false;
                        _UIManager.WeaponImage.sprite = items.WeaponList[index].ItemImage;
                    }
                    break;
                case "Helmet ItemSlot":
                    if (items.HelmetList[index].HasItem)
                    {
                        _UIManager.EquipItem(items.HelmetList[index]);
                        _UIManager.CloseItemMenu();
                        _UIManager.IsItemEquip = false;
                        _UIManager.HelmetImage.sprite = items.HelmetList[index].ItemImage;
                    }
                    break;
                case "Armor ItemSlot":
                    if (items.ArmorList[index].HasItem)
                    {
                        _UIManager.EquipItem(items.ArmorList[index]);
                        _UIManager.CloseItemMenu();
                        _UIManager.IsItemEquip = false;
                        _UIManager.ArmorImage.sprite = items.ArmorList[index].ItemImage;
                    }
                    break;
                case "Glove ItemSlot":
                    if (items.GloveList[index].HasItem)
                    {
                        _UIManager.EquipItem(items.GloveList[index]);
                        _UIManager.CloseItemMenu();
                        _UIManager.IsItemEquip = false;
                        _UIManager.GloveImage.sprite = items.GloveList[index].ItemImage;
                    }
                    break;
                case "Boots ItemSlot":
                    if (items.BootsList[index].HasItem)
                    {
                        _UIManager.EquipItem(items.BootsList[index]);
                        _UIManager.CloseItemMenu();
                        _UIManager.IsItemEquip = false;
                        _UIManager.BootsImage.sprite = items.BootsList[index].ItemImage;
                    }
                    break;
                case "Accessory ItemSlot":
                    if (items.AccessoryList[index].HasItem)
                    {
                        _UIManager.EquipItem(items.AccessoryList[index]);
                        _UIManager.CloseItemMenu();
                        _UIManager.IsItemEquip = false;
                        _UIManager.BootsImage.sprite = items.AccessoryList[index].ItemImage;
                    }
                    break;
            }
            
        }
    }

    void HasItemCheck(string ItemName,string ItemTag)
    {
        
    }
}
