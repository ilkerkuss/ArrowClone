using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    public static CanvasManager Instance;

    public InGamePanelController InGamePanel; 
    public LevelPassPanelController LevelPassPanel;
    public FailPanelController FailPanel;
    



    private void Awake()
    {
        Instance = this;

    }
    void Start()
    {
        
    }


}
