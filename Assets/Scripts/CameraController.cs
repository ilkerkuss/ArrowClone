using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public static CameraController Instance;

    [SerializeField] private PlayerController _target;
    private Vector3 _offset;

    [SerializeField] private float _lerpValue;

    private void Awake()
    {
        Instance = this;
    }


    void Start()
    {
        //_target = GameObject.FindGameObjectWithTag("Player");
        _offset = transform.position - _target.transform.position;
        _lerpValue = 3;
    }

    void LateUpdate()
    {

        if (_target != null)
        {
            Vector3 newPos = Vector3.Lerp(transform.position, _offset + _target.transform.position, _lerpValue);
            transform.position = newPos;
        }
    }

    public void SetTarget(PlayerController player)
    {
        _target = player;
    }
}
