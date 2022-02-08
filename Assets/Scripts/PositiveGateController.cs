using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PositiveGateController : MonoBehaviour
{

    public enum OperationTypes
    {
        Multiply,
        Add
    }

    public OperationTypes OperationType;

    public int[] addValues = { 10, 15, 20, 25, 30, 35, 40, 45, 50 };
    public int[] multiplyValues = {2, 3, 4, 5};

    public int OperationValue;

    [SerializeField] private TextMeshPro _posGateText;

    void Start()
    {
        //_posGateText = transform.GetChild(2).GetComponent<TextMeshPro>();
        _posGateText = gameObject.GetComponentInChildren<TextMeshPro>();

        GetRandomOperation();
        AssignOperationSign();
    }

    void Update()
    {
        
    }

    public void GetRandomOperation()
    {
        OperationType = (OperationTypes)Random.Range(0,2);

        if (OperationType == OperationTypes.Add)
        {
            OperationValue = addValues[Random.Range(0, addValues.Length)];
        }
        else
        {
            OperationValue = multiplyValues[Random.Range(0, multiplyValues.Length)];
        }

       // Debug.Log(OperationType +" :"+ OperationValue);
    }

    public void AssignOperationSign()
    {
        if (OperationType == OperationTypes.Add)
        {
            _posGateText.text = "+" + OperationValue;
        }
        else
        {
            _posGateText.text = "x" + OperationValue;
        }
    }



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<ArrowController>() == null) return;
        {
            
            if (OperationType == OperationTypes.Add)
            {
                ArrowManager.Instance.IncreaseArrow(OperationValue);
            }
            else
            {
                ArrowManager.Instance.IncreaseArrow((OperationValue-1) * ArrowManager.Instance.GetArrowNumber());
            }

            gameObject.GetComponent<BoxCollider>().enabled = false;


        }
    }



}
