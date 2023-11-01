using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float _speed;
    [SerializeField] float _jumpForce;
    [SerializeField] bool _isJumped;
    bool _isBattle;
    Rigidbody2D _playerRigidbody;
    Vector2 _direction;

    protected RaycastHit2D _hit;

#region Property
    public float Speed
    {
        get { return _speed; }
        set { _speed = value; }
    }

    public float JumpForce
    {
        get { return _jumpForce; }
        set { _jumpForce = value; }
    }

    public bool IsJumped
    {
        get { return _isJumped; }
        set { _isJumped = value; }
    }

    public bool IsBattle
    {
        get { return _isBattle; }
        set { _isBattle = value; }
    }

    public Rigidbody2D PlayerRigidbody
    {
        get { return _playerRigidbody; }
        set { _playerRigidbody = value; }
    }

    public Vector2 Direction
    {
        get { return _direction; }
        set { _direction = value; }
    }
#endregion

    protected void MoveCheck(float horizontal)
    {
        if (!IsBattle)
        {
            if (horizontal != 0)
            {
                this.transform.Translate(new Vector3(_speed * horizontal * Time.deltaTime, 0, 0));
            }
            if (Input.GetKey(KeyCode.Space) && !_isJumped)
            {
                _isJumped = true;
                _playerRigidbody.velocity = new Vector2(0, 0);
                _playerRigidbody.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
            }
            if (_hit.collider != null && _hit.collider.CompareTag("Map"))
            {
                GameObject.Find("ZoneText").GetComponent<ZoneCheck>().TextChange(_hit.collider.gameObject.GetComponent<LevelData>().Level);
                _isJumped = false;
            }
        }
    }
}
