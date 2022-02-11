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

        CanvasManager.Instance.LevelPassPanel.HidePanel();
        CanvasManager.Instance.InGamePanel.ShowPanel(); ;

        AudioManager.Instance.StopSound("LevelPassSound");


        GameManager.Instance.RestartGame();

    }


}
