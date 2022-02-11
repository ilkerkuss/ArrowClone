using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullseyeController : MonoBehaviour
{
    public delegate void ObjectEvents();
    public static event ObjectEvents CollideBullseye;


    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<ArrowController>()) // if collide with an object which has a arrowcontroller component
        {
            CollideBullseye?.Invoke(); //event invoke bullseye collision

            ArrowManager.Instance.DecreaseArrow(ArrowManager.Instance.GetArrowNumber());

            CanvasManager.Instance.LevelPassPanel.ShowPanel();
            Debug.Log("tebrikler");
        }
    }
}
