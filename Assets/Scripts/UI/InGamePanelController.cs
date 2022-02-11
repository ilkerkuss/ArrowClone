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
        SetLevelText();
        SetCoinText();
    }

    void Update()
    {
        
    }

    public void SetLevelText()
    {
        _levelText.text = "Level "+ LevelManager.Instance.GetCurrentLevel().ToString();
    }

    public void SetCoinText() //set coin number of player
    {
        _coinText.text = LevelManager.Instance.GetCurrentCoin().ToString();
    }

    public void ActivateTapToStartButton()
    {
        _tapToStartButton.gameObject.SetActive(true);
    }

    public void DisableTapToStartButton()
    {
        _tapToStartButton.gameObject.SetActive(false);
    }

    public void OnClickTapToStartButton()
    {
        GameManager.Instance.GameState = GameManager.GameStates.IsGamePlaying;

        DisableTapToStartButton();
    }


}
