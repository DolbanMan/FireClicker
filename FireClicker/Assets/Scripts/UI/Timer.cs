using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    [SerializeField] private TMP_Text _visualTimer;
    [SerializeField] private float _timeForLevel;

    public UnityEvent _EndUpdated;

    private int _timeOnSeconds;

    private void Update()
    {
        _timeForLevel -= Time.deltaTime;
        _timeOnSeconds = (int)_timeForLevel;
        _visualTimer.text = _timeOnSeconds.ToString();
        if(_timeForLevel<=0)
        {
            Time.timeScale = 0;
            _EndUpdated.Invoke();
        }
    }

}
