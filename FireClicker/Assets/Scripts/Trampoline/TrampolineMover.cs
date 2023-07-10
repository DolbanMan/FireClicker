using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampolineMover : MonoBehaviour
{
    [SerializeField] private Transform _trampolinePosition;
    [SerializeField] private float _speed;
    
    private float _normalSpeed;

    private void Update()
    {
        transform.Translate(_normalSpeed * Time.deltaTime, 0, 0);
    }

    public void ClickLeftButton()
    {
        _normalSpeed = -_speed;
    }
    public void ClickRightButton()
    {
        _normalSpeed = _speed;
    }

    public void StopMove()
    {
        _normalSpeed = 0;
    }
}
