using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowIcon : MonoBehaviour
{
    public GameObject playIcon;

    private void OnMouseEnter()
    {
        if (!playIcon.activeInHierarchy)
        {
            playIcon.SetActive(false);
        }   
    }

    private void OnMouseExit()
    {
        if (playIcon.activeInHierarchy)
        {
            playIcon.SetActive(true);
        }
    }
}
