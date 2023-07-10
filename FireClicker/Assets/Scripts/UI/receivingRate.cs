using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class receivingRate : MonoBehaviour
{
    [SerializeField] private Score _rewardCount;
    [SerializeField] private Image[] _stars;
    [SerializeField] private Sprite _receiveStar;
    [SerializeField] private int _mediumScore;
    [SerializeField] private int _highScore;

    private void Update()
    {
        DefinitionReward(_rewardCount.Reward);
    }

    private void DefinitionReward(int Score)
    {
        
        if (Score >= _highScore)
        {
            _stars[0].sprite = _receiveStar;
            _stars[1].sprite = _receiveStar;
            _stars[2].sprite = _receiveStar;
        }
        else if (Score >= _mediumScore)
        {
            _stars[0].sprite = _receiveStar;
            _stars[1].sprite = _receiveStar;
        }
        else
        {
            _stars[0].sprite = _receiveStar;
        }
    }
}
