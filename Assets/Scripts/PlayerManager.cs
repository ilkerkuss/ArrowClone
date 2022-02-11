using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance;

    [SerializeField] private PlayerController _playerPrefab;
    [SerializeField] private PlayerController _currentPlayer;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        GeneratePlayer();
    }


    public void GeneratePlayer()
    {
        if (_currentPlayer != null)
        {
            Destroy(_currentPlayer.gameObject);
        }

        _currentPlayer = Instantiate(_playerPrefab,_playerPrefab.transform.position,Quaternion.identity);

        CameraController.Instance.SetTarget(_currentPlayer); // set new camera target 
    }
}
