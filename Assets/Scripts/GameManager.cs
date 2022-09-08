using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject player, spawnManager, startMenu, pauseMenu, gameOverMenu, healthBar;
    [SerializeField] TextMeshProUGUI timer;
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
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isRunning)
        {
            PauseGame();
        }
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
        pauseMenu.SetActive(true);
        healthBar.SetActive(true);
        player.SetActive(false);
        spawnManager.SetActive(false);
        //isRunning = false;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {

    }
}
