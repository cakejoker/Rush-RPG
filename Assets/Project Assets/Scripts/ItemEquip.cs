using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemEquip : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] UIManager _UIManager;

    public void OnPointerClick(PointerEventData eventData)
    {
        _UIManager.ItemEquip();
    }
}
