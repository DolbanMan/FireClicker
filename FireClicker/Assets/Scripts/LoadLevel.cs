using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 1;
    }
    public void LoadScene(int NumberScene)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + NumberScene);
    }
}
