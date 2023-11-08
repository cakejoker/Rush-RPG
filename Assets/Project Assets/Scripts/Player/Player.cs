using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : PlayerController
{
    private event EventHandler OnEncountHandler;

    private Battle _battle;
    private LevelData _level;
    private Equipment _equipment;
   
    private float _encountPercent;
    private int _rand;

    public ItemList _ownItemList;

    public int _atk;
    public int _def;
    public int _maxHp;
    public int _currentHp;   

    public float EncountPercent
    {
        get { return _encountPercent; }
        set
        {
            _encountPercent = value;
            if(value >= 100.0f)
            {
                _encountPercent = 100.0f;
            }
            if(value == 0)
            {
                OnEncountHandler(this, EventArgs.Empty);
            }
        }
    }

    private void Start()
    {
        PlayerRigidbody = this.GetComponent<Rigidbody2D>();
        _battle = this.GetComponent<Battle>();
        Direction = new Vector2(0, -0.6f);
        IsJumped = false;
        this.OnEncountHandler += new EventHandler(OnEncount);
        _level = null;
        EncountPercent = 0;
    }

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        _hit = Physics2D.Raycast(this.transform.position, Direction, 0.6f, LayerMask.GetMask("Map"));
        
        Debug.DrawRay(this.transform.position, Direction, Color.red);
        if(_hit.collider != null)
        {
            _level = _hit.collider.gameObject.GetComponent<LevelData>();
        }
        MoveCheck(horizontal);
        if (horizontal != 0)
        {
            EncountPercent += (0.05f * Time.deltaTime) * 100;
            if(_rand < EncountPercent)
            {
                _battle.BattleStart(_level.SetSpawnMonster());
                EncountPercent = 0;
            }
        }
    }

    void OnEncount(object sender, EventArgs e)
    {
        _rand = UnityEngine.Random.Range(0, 100);
    }


}
