using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject player, spawnManager, startMenu, pauseMenu, gameOverMenu, healthBar, sensor;
    [SerializeField] TextMeshProUGUI timer;
    SensorBehaviour sensorBehaviour;
    float playerHealth, timeTracker;
    bool isRunning;

    void Start()
    {
        startMenu.SetActive(true);
        pauseMenu.SetActive(false);
        gameOverMenu.SetActive(false);
        healthBar.SetActive(false);
        player.SetActive(false);
        spawnManager.SetActive(false);
        isRunning = false;
        sensorBehaviour = sensor.GetComponent<SensorBehaviour>();
        timeTracker = 0;
    }

    void Update()
    {
        playerHealth = sensorBehaviour.currentHealth;

        if (isRunning)
        {
            timeTracker += Time.deltaTime;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                PauseGame();
            }
    
            if(playerHealth <= 0)
            {
                GameOver();
            }
        }

        timer.text = "Timer: " + timeTracker.ToString("0.0");
    }

    public void PlayGame()
    {
        startMenu.SetActive(false);
        pauseMenu.SetActive(false);
        healthBar.SetActive(true);
        player.SetActive(true);
        spawnManager.SetActive(true);
        isRunning = true;
        Debug.Log("isRunning = " + isRunning);
    }

    public void PauseGame()
    {
        isRunning = false;
        pauseMenu.SetActive(true);
        healthBar.SetActive(true);
        player.SetActive(false);
        spawnManager.SetActive(false);
    }

    public void GameOver()
    {
        isRunning = false;
        startMenu.SetActive(false);
        pauseMenu.SetActive(false);
        gameOverMenu.SetActive(true);
        healthBar.SetActive(false);
        player.SetActive(false);
        spawnManager.SetActive(false);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
        #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
        #else
        Application.Quit();
        #endif
    }
}
