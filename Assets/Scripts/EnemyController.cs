using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

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
            ArrowManager.Instance.ShootWithArrow(gameObject);
            gameObject.GetComponent<BoxCollider>().enabled = false;
            AudioManager.Instance.PlaySound("ArrowSound");

            if (ArrowManager.Instance.GetArrowNumber() > 1)
            {
                ArrowManager.Instance.DecreaseArrow(1);
            }
            else
            {
                GameManager.Instance.GameOver();
            }
        }
    }
}
