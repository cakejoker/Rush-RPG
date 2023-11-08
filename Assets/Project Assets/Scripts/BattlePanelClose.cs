using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BattlePanelClose : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        if(GameManager.Instance.IsBattleEnd)
        {
            this.gameObject.SetActive(false);
            GameManager.Instance.IsBattleEnd = false;
        }
    }
}
