using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // 신을 넘기는 매니져

public class Select_Canvas_UI_Action : MonoBehaviour
{
    public GameObject cubeOneObject;
    public GameObject music01;
    public GameObject music02;
    public GameObject music03;
    public GameObject music04;
    public GameObject music05;

    // public Select_Canvas_UI SCU;
    public void PressedCancle()
    {
        cubeOneObject.SetActive(false);
        OnActive();
    }

    public void PressedStart()
    {
        SceneManager.LoadScene("Scene#3-1");
        
        // SCU = cubeOneObject.GetComponent<Select_Canvas_UI>();

        //Static_Information.Music_Name = SCU.m_Name.text;

    }

    public void OnActive()
    {
        music01.GetComponent<BoxCollider>().enabled = true;
        music02.GetComponent<BoxCollider>().enabled = true;
        music03.GetComponent<BoxCollider>().enabled = true;
        music04.GetComponent<BoxCollider>().enabled = true;
        music05.GetComponent<BoxCollider>().enabled = true;

    }
}
