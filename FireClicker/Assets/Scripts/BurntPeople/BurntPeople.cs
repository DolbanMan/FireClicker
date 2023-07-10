using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BurntPeople : MonoBehaviour
{
    [SerializeField] private float _repusiveForce;
    [SerializeField] private float _repulsiveDirection;
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private int _reward;

    private bool _trampoline—ontact = false;
    private bool _controlReward = false;
    private int _currentPoint;

    public bool TramplineContact => _trampoline—ontact;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.GetComponent<Trampoline>())
        {
            _rigidbody.AddForce((Vector2.up * _repusiveForce) + new Vector2(Random.Range(_repulsiveDirection, -_repulsiveDirection), 0), ForceMode2D.Impulse);
            _trampoline—ontact = true;
        }
        else if (_trampoline—ontact == false)
        {
            Destroy(gameObject);
        }
    }

    public void GiveReward(UnityAction<int> ScoreChanged)
    {
        if (_controlReward == false)
        {
            ScoreChanged.Invoke(_reward);
            _controlReward = true;
        }
    }

}
