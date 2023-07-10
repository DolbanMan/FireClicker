using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private SpawnPoint[] _spawnPoints;
    [SerializeField] private BurntPeople[] _burntPeople;
    [SerializeField] private float _secondsBetweenSpawn;

    private float _elapsedTime;

    private void Update()
    {
        _elapsedTime += Time.deltaTime;

        if(_elapsedTime>=_secondsBetweenSpawn)
        {
            _elapsedTime = 0;

            int SpawnPointNumber = Random.Range(0, _spawnPoints.Length);
            int BurntPeopleNumber = Random.Range(0, _burntPeople.Length);
            Instantiate(_burntPeople[BurntPeopleNumber], _spawnPoints[SpawnPointNumber].transform.position,Quaternion.identity);
        }
    }

}
