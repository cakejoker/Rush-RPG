using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Battle : MonoBehaviour
{
    [SerializeField] GameObject _battlePanel;
    [SerializeField] GameObject _weaponListPanel;
    [SerializeField] Image _targetMonster;
    [SerializeField] GameObject _battleInfoPanel;
    [SerializeField] Image _dropItemImage;
    [SerializeField] Text _dropItemText;
    [SerializeField] Text _gainEXP;
    [SerializeField] Text _gainGold;
    [SerializeField] UIManager UI;

    Player _playerData;
    GameObject itemSlot;

    private void Start()
    {
        _battlePanel.SetActive(false);
        _battleInfoPanel.SetActive(false);
    }

    public void BattleStart(MonsterData monsterData)
    {
        _battlePanel.SetActive(true);
        _battleInfoPanel.SetActive(false);
        GameManager.Instance.IsBattleEnd = false;
        _targetMonster.gameObject.SetActive(true);
        _targetMonster.sprite = monsterData.MonsterImage;
        monsterData.CurrentHP = monsterData.MaxHP;
        _playerData = this.GetComponent<Player>();
        _playerData.CurrentHP = _playerData.MaxHP;
        _playerData.IsBattle = true;
        Debug.Log("BattleStart!");
        StartCoroutine(BattlePhase(monsterData.SetDropItem(),monsterData));
    }

    private IEnumerator BattlePhase(ItemData itemData, MonsterData monsterData)
    {
        while(true)
        {
            monsterData.CurrentHP -= _playerData.ATK;
            Debug.Log($"Monster : {monsterData.CurrentHP}");
            if (monsterData.CurrentHP <= 0)
            {
                GameManager.Instance.IsBattleEnd = true;
                switch (itemData.ItemType)
                {
                    case ItemData.ItemTypes.Weapon:
                        _playerData._ownItemList.WeaponList[itemData.ItemID].HasItem = true;
                        itemSlot = _weaponListPanel.transform.GetChild(itemData.ItemID).gameObject;
                        Weapon weapon = itemData as Weapon;
                        UI.GetItem(weapon);
                        break;
                    case ItemData.ItemTypes.Helmet:
                        _playerData._ownItemList.HelmetList[itemData.ItemID].HasItem = true;
                        itemSlot = _weaponListPanel.transform.GetChild(itemData.ItemID).gameObject;
                        Helmet helmet = itemData as Helmet;
                        UI.GetItem(helmet);
                        break;
                    case ItemData.ItemTypes.Armor:
                        _playerData._ownItemList.ArmorList[itemData.ItemID].HasItem = true;
                        itemSlot = _weaponListPanel.transform.GetChild(itemData.ItemID).gameObject;
                        Armor armor = itemData as Armor;
                        UI.GetItem(armor);
                        break;
                    case ItemData.ItemTypes.Glove:
                        _playerData._ownItemList.GloveList[itemData.ItemID].HasItem = true;
                        itemSlot = _weaponListPanel.transform.GetChild(itemData.ItemID).gameObject;
                        Glove glove = itemData as Glove;
                        UI.GetItem(glove);
                        break;
                    case ItemData.ItemTypes.Boots:
                        _playerData._ownItemList.BootsList[itemData.ItemID].HasItem = true;
                        itemSlot = _weaponListPanel.transform.GetChild(itemData.ItemID).gameObject;
                        Boots boots = itemData as Boots;
                        UI.GetItem(boots);
                        break;
                    case ItemData.ItemTypes.Accessory:
                        _playerData._ownItemList.AccessoryList[itemData.ItemID].HasItem = true;
                        itemSlot = _weaponListPanel.transform.GetChild(itemData.ItemID).gameObject;
                        Accessory accessory = itemData as Accessory;
                        UI.GetItem(accessory);
                        break;
                }
                _targetMonster.gameObject.SetActive(false);
                _battleInfoPanel.SetActive(true);
                _gainEXP.text = $"EXP : {monsterData.EXP}";
                _gainGold.text = $"Gold : {monsterData.Gold}";
                _dropItemImage.sprite = itemData.ItemImage;
                _dropItemText.text = itemData.ItemName;
                break;
            }               
            yield return new WaitForSeconds(0.5f);

            _playerData.CurrentHP -= (monsterData.ATK - _playerData.DEF < 0) ? 0 : (monsterData.ATK - _playerData.DEF);
            Debug.Log($"Player : {_playerData.CurrentHP}");
            if (_playerData.CurrentHP <= 0)
            {
                break;
            }
            yield return new WaitForSeconds(0.5f);
        }
        _playerData.IsBattle = false;
        Debug.Log("BattleEnd");
    }
}
