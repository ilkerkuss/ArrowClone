using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGamePanelController : CanvasController
{
    [SerializeField] private Button _tapToStartButton;

    [SerializeField] private Text _levelText;
    [SerializeField] private Text _coinText;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetLevelText()
    {
        _levelText.text = LevelManager.Instance.GetCurrentLevel().ToString();
    }



    public void ActivateTapToStartButton()
    {
        _tapToStartButton.gameObject.SetActive(true);
    }

    public void DisableTapToStartButton()
    {
        _tapToStartButton.gameObject.SetActive(false);
    }


}
