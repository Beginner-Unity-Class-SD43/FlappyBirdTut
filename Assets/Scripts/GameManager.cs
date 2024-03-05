using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; // This is a singleton. This lets you call the code from anywhere without having to get the object in code.

    [SerializeField] GameObject canvas;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }

        Time.timeScale = 1f;
    }

    public void GameOver()
    {
        canvas.SetActive(true);

        Time.timeScale = 0f; // Freezes time
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
