using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ArrowController : MonoBehaviour
{
    /*
    public delegate void ObjectEvents();
    public static event  ObjectEvents CollideBullseye;
    */

    //public static event Action<String>CollideBullseye;

    void Start()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
       /*
        if (collision.transform.CompareTag("PositiveGate"))
        {
            ArrowManager.Instance.IncreaseArrow(20);
            //Destroy(collision.gameObject);
            //collision.gameObject.tag = "Untagged";
            collision.gameObject.GetComponent<BoxCollider>().enabled = false;

        }
      */

        /*
        if (collision.transform.CompareTag("NegativeGate"))
        {
            collision.gameObject.GetComponent<BoxCollider>().enabled = false;

            if (ArrowManager.Instance.GetArrowNumber()> 10) // arrow number check for decrement
            {
                ArrowManager.Instance.DecreaseArrow(10);
            }
            else
            {
                GameManager.Instance.GameOver();
            }
          
            
        }
        */

        /*
        if (collision.transform.CompareTag("Enemy"))
        {

            ArrowManager.Instance.ShootWithArrow(collision.gameObject);
            collision.gameObject.GetComponent<BoxCollider>().enabled = false;

            if (ArrowManager.Instance.GetArrowNumber() > 1)
            {
                ArrowManager.Instance.DecreaseArrow(1);
            }
            else
            {
                GameManager.Instance.GameOver();
            }

        }
        */
        /*
        if (collision.transform.CompareTag("Bullseye"))
        {
            CollideBullseye?.Invoke(); //event invoke bullseye collision

            //PlayerPrefs.SetInt("Coin", ArrowManager.Instance.GetArrowNumber()*10);
            ArrowManager.Instance.DecreaseArrow(ArrowManager.Instance.GetArrowNumber());
            

            CanvasManager.Instance.LevelPassPanel.ShowPanel();
            Debug.Log("tebrikler");
        }
        */

    }
}
