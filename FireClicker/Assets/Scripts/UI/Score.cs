using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text _scorePlayer;
    [SerializeField] private Trampoline _mob;

    private int _reward;

    public int Reward => _reward;

    private void Update()
    {
        _scorePlayer.text = _reward.ToString();
    }

    private void OnEnable()
    {
        _mob.ScoreChanged += OnScoreChanged;
    }

    private void OnDisable()
    {
        _mob.ScoreChanged -= OnScoreChanged;
    }

    private void OnScoreChanged(int reward)
    {
        _reward += reward;
    }

}
