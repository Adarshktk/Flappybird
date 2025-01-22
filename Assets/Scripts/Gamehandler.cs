using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamehandler : MonoBehaviour
{
    public static Gamehandler Instance;

    [SerializeField] private GameObject gameOverUI;

    private void Awake()
    {

        if (Instance == null)
        {
            Instance = this;
        }
        gameOverUI.SetActive(false);
        Time.timeScale = 1f;
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        gameOverUI.SetActive(true);
        
    }
    public void Restart()
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(index);
    }
}
