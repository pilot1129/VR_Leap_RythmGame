using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //추가

public class EndScript : MonoBehaviour {

    public void StartGame()
    {
        SceneManager.LoadScene("Scene#2-1"); // scene2 소환
    }//Scene#1 Startbutton

    public void StartRythm()
    {
        SceneManager.LoadScene("Scene#3-1");
    }// Scene#2 Startbutton

    public void OptionMenu()
    {
        SceneManager.LoadScene("Scene#01_Option"); // scene01_option 소환
    }// Scene#1 Optionbutton
    public void ExitMenu()
    {
        SceneManager.LoadScene("Scene#1-1");
    }// Scene#2 Exitbutton

    public void ExitGame()
    {
        Debug.Log("Exit Button Pressed"); // 디버그 로그 호출
        Application.Quit(); // 어플 종료
    }	
}
