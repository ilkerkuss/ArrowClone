using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CanvasController : MonoBehaviour
{
    public void HidePanel()
    {
        gameObject.SetActive(false);

    }

    public void ShowPanel()
    {
        gameObject.SetActive(true);
    }
}
