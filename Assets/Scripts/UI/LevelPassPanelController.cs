using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelPassPanelController : CanvasController
{
    [SerializeField] private Button _nextLevelButton;


    void Start()
    {
        
    }

    public void OnClickNextLevelButton()
    {
        GameManager.Instance.GameState = GameManager.GameStates.IsGameLoaded;

        LevelManager.Instance.GenerateLevel();
        PlayerManager.Instance.GeneratePlayer();

        CanvasManager.Instance.LevelPassPanel.HidePanel();
        CanvasManager.Instance.InGamePanel.ShowPanel(); ;


        GameManager.Instance.RestartGame();

    }


}
