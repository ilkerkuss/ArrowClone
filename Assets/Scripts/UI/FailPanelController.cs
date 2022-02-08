using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FailPanelController : CanvasController
{
    [SerializeField] private Button _restartButton;


    void Start()
    {
        
    }

    public void OnClickRestartButton()
    {
        GameManager.Instance.RestartGame();

    }


}
