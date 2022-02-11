using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] private int _arrowNumber;


    void Start()
    {
        _arrowNumber = ArrowManager.Instance.GetArrowNumber();
    }


    private void OnEnable()
    {
        //ArrowController.CollideBullseye += CheckLevelPassed;
        BullseyeController.CollideBullseye += CheckLevelPassed;
    }

    private void OnDisable()
    {
        //ArrowController.CollideBullseye -= CheckLevelPassed;
        BullseyeController.CollideBullseye -= CheckLevelPassed;
    }



    private void CheckLevelPassed()
    {
        if (_arrowNumber==0)
        {
            Destroy(gameObject);

        }

        LevelManager.Instance.LevelPassed();
    }
}
