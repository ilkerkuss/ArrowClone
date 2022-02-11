using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private SwerveInputSystem _swerveInputSystem;
    [SerializeField] private float swerveSpeed = 3.5f;
    [SerializeField] private float maxSwerveAmount = 1f;


    private float _forwardSpeed = 10f;


    private void Awake()
    {
        _swerveInputSystem = GetComponent<SwerveInputSystem>();

    }

    void FixedUpdate()
    {
        if (GameManager.Instance.GameState == GameManager.GameStates.IsGamePlaying)
        {
            SwerveMove();
        }
        

    }

    private void SwerveMove()
    {
        transform.Translate(Vector3.forward * (Time.fixedDeltaTime * _forwardSpeed));

        //swerve hareketi
        float swerveAmount = Time.fixedDeltaTime * swerveSpeed * _swerveInputSystem.MoveFactorX;
        swerveAmount = Mathf.Clamp(swerveAmount, -maxSwerveAmount, maxSwerveAmount);
        transform.Translate(swerveAmount, 0, 0);
    }

}
