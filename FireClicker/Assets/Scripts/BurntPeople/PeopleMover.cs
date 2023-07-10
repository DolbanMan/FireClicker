using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Animator _animator;
    private BurntPeople _burntPeople;
    private SpriteRenderer _spriteRenderer;
    private bool _leftMove;
    private bool _rightMove;

    private void Start()
    {
        _burntPeople = GetComponent<BurntPeople>();
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
       if(_burntPeople.TramplineContact)
        {
            if (_rightMove)
            {
                transform.Translate(Vector2.right * _speed * Time.deltaTime);
                _animator.SetBool("isRunning", true);
            }
            if (_leftMove)
            {
                transform.Translate(Vector2.left * _speed * Time.deltaTime);
                _animator.SetBool("isRunning", true);
                _spriteRenderer.flipX = true;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<LeftFloor>())
            _leftMove = true;
        if (collision.gameObject.GetComponent<RightFloor>())
            _rightMove = true;
    }

}
