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

    #region Status
    [Header("Status")]
    [SerializeField] private int _atk;
    public int ATK
    {
        get { return _atk; }
        set { _atk = value; }
    }

    [SerializeField] private int _def;
    public int DEF
    {
        get { return _def; }
        set { _def = value; }
    }

    [SerializeField] private int _HP;
    public int HP
    {
        get { return _HP; }
        set { _HP = value; }
    }

    [SerializeField] private int _luc;
    public int LUC
    {
        get { return _luc; }
        set { _luc = value; }
    }

    [SerializeField] private int _SP;
    public int SP
    {
        get { return _SP; }
        set { _SP = value; }
    }
    #endregion

    [Space]
    public ItemList _ownItemList;

    private int _maxHp;
    public int MaxHP
    {
        get { return _maxHp; }
        set { _maxHp = value; }
    }

    private int _currentHp;
    public int CurrentHP
    {
        get { return _currentHp; }
        set { _currentHp = value; }
    }

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
        _maxHp = _HP * 10;
        _SP = 0;
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

    public void EquipItem()
    {

    }
}
