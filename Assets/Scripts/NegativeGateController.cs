using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NegativeGateController : MonoBehaviour
{
    public enum OperationTypes
    {
        Substract,
        Divide
    }

    public OperationTypes OperationType;

    public int[] substractValues = { 10, 15 };
    public int[] divisionValues = { 2, 3};

    public int OperationValue;

    [SerializeField] private TextMeshPro _negGateText;


    void Start()
    {
        _negGateText = transform.GetChild(2).GetComponent<TextMeshPro>();

        GetRandomOperation();
        AssignOperationSign();
    }


    public void GetRandomOperation()
    {
        OperationType = (OperationTypes)Random.Range(0, 2);

        if (OperationType == OperationTypes.Substract)
        {
            OperationValue = substractValues[Random.Range(0, substractValues.Length)];
        }
        else
        {
            OperationValue = divisionValues[Random.Range(0, divisionValues.Length)];
        }

        // Debug.Log(OperationType +" :"+ OperationValue);
    }

    public void AssignOperationSign()
    {
        if (OperationType == OperationTypes.Substract)
        {
            _negGateText.text = "-" + OperationValue;
        }
        else
        {
            _negGateText.text = ":" + OperationValue;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Arrow"))
        {
         
            if (OperationType == OperationTypes.Substract)
            {
                if (ArrowManager.Instance.GetArrowNumber() > OperationValue) // arrow number check for decrement
                {
                    ArrowManager.Instance.DecreaseArrow(OperationValue);
                }
                else
                {
                    GameManager.Instance.GameOver();
                }
                
            }
            else
            {
                if (ArrowManager.Instance.GetArrowNumber() >= 1)
                {
                    ArrowManager.Instance.DecreaseArrow((ArrowManager.Instance.GetArrowNumber()/(OperationValue)) * (OperationValue-1)); // division operation 

                }
                else
                {
                    GameManager.Instance.GameOver();
                }
            }

            gameObject.GetComponent<BoxCollider>().enabled = false;


        }
    }
}
