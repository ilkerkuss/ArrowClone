using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;

    [SerializeField] private GameObject[] _levelList;
    [SerializeField] private GameObject _instantiatedLevel;


    private int _currentLevel;
    private int _currentCoin;


    private void Awake()
    {
        Instance = this;

    }
    void Start()
    {
        _currentLevel = PlayerPrefs.GetInt("Level", 0);
        _currentCoin = PlayerPrefs.GetInt("Coin",0);
        GenerateLevel();
    }


    public void GenerateLevel()
    {
        if (_instantiatedLevel != null)
        {
            Destroy(_instantiatedLevel.gameObject);
        }

        _instantiatedLevel = Instantiate(_levelList[_currentLevel % (_levelList.Length)], Vector3.zero, Quaternion.identity);

    }

    public void LevelPassed()
    {
        GameManager.Instance.GameState = GameManager.GameStates.IsGameOver;

        _currentLevel++;
        PlayerPrefs.SetInt("Level",_currentLevel);

        _currentCoin = _currentCoin + (ArrowManager.Instance.GetArrowNumber() * 10);
        PlayerPrefs.SetInt("Coin", _currentCoin);

        AudioManager.Instance.PlaySound("LevelPassSound");
    }


    public int GetCurrentLevel()
    {
        return PlayerPrefs.GetInt("Level",0);
    }

    public int GetCurrentCoin()
    {
        return PlayerPrefs.GetInt("Coin",0);
    }
}
