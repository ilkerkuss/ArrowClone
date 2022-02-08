using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public enum GameStates
    {
        IsGameLoaded,
        IsGamePlaying,
        IsGameOver,
        IsGamePaused
    }

    public GameStates GameState;

    public bool IsGameMuted;

    private void Awake()
    {

        Instance = this;

    }


    void Start()
    {
        GameState = GameStates.IsGameLoaded;
    }

    void Update()
    {
        
    }

    public void RestartGame()
    {
        GameState = GameStates.IsGameLoaded;
    }

    public void GameOver()
    {
        GameState = GameStates.IsGameOver;


        Time.timeScale = 0;
        Debug.Log("kaybettiniz");

    }
}
