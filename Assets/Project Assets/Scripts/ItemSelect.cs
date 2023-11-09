using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSelect : MonoBehaviour,IPointerClickHandler
{
    [SerializeField] UIManager _UIManager;
    [SerializeField] Player _player;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (_UIManager.IsItemEquip)
        {
            
            _player.EquipItem();
        }
    }

    void HasItemCheck(string ItemName,string ItemTag)
    {
        
    }
}
