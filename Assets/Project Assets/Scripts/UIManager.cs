using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Space]
    [Header("PlayerData")]
    [SerializeField] Player _player;

    [Space]
    [Header("Panel")]
    public GameObject MenuUI;
    public GameObject ItemMenuUI;
    public GameObject StatusMenuUI;

    [Space]
    [Header("Content")]
    public GameObject ItemSlot;
    public GameObject WeaponContent;
    public GameObject HelmetContent;
    public GameObject ArmorContent;
    public GameObject GloveContent;
    public GameObject BootsContent;
    public GameObject AccessoryContent;

    [Space]
    [Header("Status UI")]
    public Text HPText;
    public Text ATKText;
    public Text DEFText;
    public Text LUCText;
    public Text SPText;

    [Space]
    [Header("Item Equip UI")]
    public Image WeaponImage;
    public Image HelmetImage;
    public Image ArmorImage;
    public Image GloveImage;
    public Image BootsImage;
    public Image[] AccessoryImages;


    [HideInInspector] public bool IsItemEquip;
    [HideInInspector] public string EquipSlotTag;

    private ItemList _itemList;


    private void Start()
    {
        _itemList = GameManager.Instance.ItemLists;
        IsItemEquip = false;
        for(int i = 0; i < _itemList.WeaponList.Count;i++ )
        {
            GameObject temp = Instantiate(ItemSlot);
            temp.name = "Weapon ItemSlot";
            temp.transform.SetParent(WeaponContent.transform);
        }
        for (int i = 0; i < _itemList.HelmetList.Count; i++)
        {
            GameObject temp = Instantiate(ItemSlot);
            temp.name = "Helmet ItemSlot";
            temp.transform.SetParent(HelmetContent.transform);
        }
        for (int i = 0; i < _itemList.ArmorList.Count; i++)
        {
            GameObject temp = Instantiate(ItemSlot);
            temp.name = "Armor ItemSlot";
            temp.transform.SetParent(ArmorContent.transform);
        }
        for (int i = 0; i < _itemList.GloveList.Count; i++)
        {
            GameObject temp = Instantiate(ItemSlot);
            temp.name = "Glove ItemSlot";
            temp.transform.SetParent(GloveContent.transform);
        }
        for (int i = 0; i < _itemList.BootsList.Count; i++)
        {
            GameObject temp = Instantiate(ItemSlot);
            temp.name = "Boots ItemSlot";
            temp.transform.SetParent(BootsContent.transform);
        }
        for (int i = 0; i < _itemList.AccessoryList.Count; i++)
        {
            GameObject temp = Instantiate(ItemSlot);
            temp.name = "Accessory ItemSlot";
            temp.transform.SetParent(AccessoryContent.transform);
        }
    }

    public void OpenMenu()
    {
        MenuUI.SetActive(true);
    }

    public void CloseMenu()
    {
        MenuUI.SetActive(false);
    }

    public void OpenItemMenu()
    {
        ItemMenuUI.SetActive(true);
    }

    public void CloseItemMenu()
    {
        ItemMenuUI.SetActive(false);
        IsItemEquip = false;
    }

    public void OpenStatusMenu()
    {
        HPText.text = _player.HP.ToString();
        ATKText.text = _player.ATK.ToString();
        DEFText.text = _player.DEF.ToString();
        LUCText.text = _player.LUC.ToString();
        SPText.text = _player.SP.ToString();
        StatusMenuUI.SetActive(true);
    }

    public void CloseStatusMenu()
    {
        StatusMenuUI.SetActive(false);
    }

    public void GetItem(Weapon weapon)
    {
        Transform paranet = WeaponContent.transform.GetChild(weapon.ItemID);
        paranet.GetChild(0).GetComponent<Text>().text = weapon.ItemName;
        paranet.GetChild(1).GetComponent<Image>().sprite = weapon.ItemImage;
        paranet.GetChild(2).GetComponent<Text>().text =
            "ATK : +" + weapon.Attack.ToString() + "\n\n" +
            "ATK% : +" + (weapon.ATKMultiply * 100).ToString() + "%";
    }

    public void GetItem(Helmet helmet)
    {
        Transform paranet = HelmetContent.transform.GetChild(helmet.ItemID);
        paranet.GetChild(0).GetComponent<Text>().text = helmet.ItemName;
        paranet.GetChild(1).GetComponent<Image>().sprite = helmet.ItemImage;
        paranet.GetChild(2).GetComponent<Text>().text =
            "HP : +" + helmet.HP.ToString() + "\n\n" +
            "DEF : +" + helmet.DEF.ToString() + "%";
    }

    public void GetItem(Armor armor)
    {
        Transform paranet = ArmorContent.transform.GetChild(armor.ItemID);
        paranet.GetChild(0).GetComponent<Text>().text = armor.ItemName;
        paranet.GetChild(1).GetComponent<Image>().sprite = armor.ItemImage;
        paranet.GetChild(2).GetComponent<Text>().text =
            "DEF : +" + armor.DEF.ToString() + "\n\n" +
            "DEF% : +" + (armor.DEFMultiply * 100).ToString() + "%";
    }

    public void GetItem(Glove glove)
    {
        Transform paranet = GloveContent.transform.GetChild(glove.ItemID);
        paranet.GetChild(0).GetComponent<Text>().text = glove.ItemName;
        paranet.GetChild(1).GetComponent<Image>().sprite = glove.ItemImage;
        paranet.GetChild(2).GetComponent<Text>().text =
            "DEF : +" + glove.DEF.ToString();
    }

    public void GetItem(Boots boots)
    {
        Transform paranet = BootsContent.transform.GetChild(boots.ItemID);
        paranet.GetChild(0).GetComponent<Text>().text = boots.ItemName;
        paranet.GetChild(1).GetComponent<Image>().sprite = boots.ItemImage;
        paranet.GetChild(2).GetComponent<Text>().text =
            "DEF : +" + boots.DEF.ToString() + "\n\n" +
            "SPEED : +" + (boots.Speed * 100).ToString() + "%";
    }

    public void GetItem(Accessory accessory)
    {
        Transform paranet = AccessoryContent.transform.GetChild(accessory.ItemID);
        paranet.GetChild(0).GetComponent<Text>().text = accessory.ItemName;
        paranet.GetChild(1).GetComponent<Image>().sprite = accessory.ItemImage;
        paranet.GetChild(2).GetComponent<Text>().text = accessory.ItemEffect;    
    }
    public void EquipItem(Weapon weaponData)
    {
        _player.Equipments.EquipWeapon = weaponData;
    }

    public void EquipItem(Helmet helmetData)
    {
        _player.Equipments.EquipHelmet = helmetData;
    }

    public void EquipItem(Armor armorData)
    {
        _player.Equipments.EquipArmor = armorData;
    }

    public void EquipItem(Glove gloveData)
    {
        _player.Equipments.EquipGlove = gloveData;
    }

    public void EquipItem(Boots bootsData)
    {
        _player.Equipments.EquipBoots = bootsData;
    }

    public void EquipItem(Accessory accessoryData)
    {

    }

    public void StatusChange()
    {

    }

    public void ItemEquip(string tag)
    {
        EquipSlotTag = tag;
        IsItemEquip = true;
        OpenItemMenu();
    }
}
