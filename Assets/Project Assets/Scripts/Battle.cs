using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle : MonoBehaviour
{
    [SerializeField] GameObject _battlePanel;

    private GameObject _targetMonster;
    private MonsterData _monsterData;
    private Player _playerData;

    public void BattleStart(GameObject targetMonster)
    {
        _battlePanel.SetActive(true);
        _targetMonster = Instantiate(targetMonster);
        _targetMonster.transform.position = _battlePanel.transform.GetChild(0).transform.position;
        _targetMonster.transform.parent = _battlePanel.transform;
        _monsterData = _targetMonster.GetComponent<MonsterData>();
        _playerData = this.GetComponent<Player>();
        _playerData.IsBattle = true;
        StartCoroutine(BattlePhase(_monsterData.SetDropItem()));
        Debug.Log("BattleStart!");
    }

    private IEnumerator BattlePhase(ItemData itemData)
    {
        while(true)
        {
            _monsterData._currentHp -= _playerData._atk;
            Debug.Log($"Monster : {_monsterData._currentHp}");
            if (_monsterData._currentHp <= 0)
            {
                Debug.Log($"Drop!\n " +
                    $"{itemData.ItemName}\n" +
                    $"{itemData.ItemID}\n" +
                    $"{itemData.ItemType}");
                break;
            }               
            yield return new WaitForSeconds(0.5f);

            _playerData._currentHp -= (_monsterData._atk - _playerData._def < 0) ? 0 : (_monsterData._atk - _playerData._def);
            Debug.Log($"Player : {_playerData._currentHp}");
            if (_playerData._currentHp <= 0)
            {
                break;
            }
            yield return new WaitForSeconds(0.5f);
        }
        _playerData.IsBattle = false;
        Debug.Log("BattleEnd");
    }
}
