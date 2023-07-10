using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Trampoline : MonoBehaviour
{    
    public event UnityAction<int> ScoreChanged;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out BurntPeople burntPeople))
        {
            burntPeople.GiveReward(ScoreChanged);
        }
    }
}
