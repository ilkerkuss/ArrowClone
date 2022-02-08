using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject _target;
    private Vector3 _offset;

    [SerializeField] private float _lerpValue;

    void Start()
    {
        _target = GameObject.FindGameObjectWithTag("Player");
        _offset = transform.position - _target.transform.position;
        _lerpValue = 3;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 pos = _target.transform.position + _offset;
        transform.position = Vector3.Lerp(transform.position, pos, _lerpValue);
    }
}
