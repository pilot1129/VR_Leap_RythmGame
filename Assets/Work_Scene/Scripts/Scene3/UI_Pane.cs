using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Pane : MonoBehaviour {

    public GameObject pane;

    public void Active()
    {
        pane.SetActive(true);
    }
    public void DeActive()
    {
        pane.SetActive(false);
    }
}
