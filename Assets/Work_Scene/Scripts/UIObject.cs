using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIObject : MonoBehaviour {

    public GameObject PalmUIMenuButton;
    public GameObject PalmUIOptionButton;
    public GameObject PalmUIBackButton;
    public GameObject PalmUIExitButton;

    public GameObject UIPane;
    public GameObject optionPane;

    public void Start()
    {
        DisableButton();
    }

    public void DisableButton()
    {
        PalmUIMenuButton.SetActive(false);
        PalmUIExitButton.SetActive(false);
    }

    public void EnableButton()
    {
        PalmUIMenuButton.SetActive(true);
        PalmUIExitButton.SetActive(true);
    }
}
