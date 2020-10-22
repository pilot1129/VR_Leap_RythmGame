using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public GameObject PalmUI;
    public GameObject Animation;

    public static bool isPause = false;

    public void Resume() //resume 버튼 push
    {
        PalmUI.SendMessage("DisableButton");
        Animation.SendMessage("PlayBackward");
        isPause = false;
    }
    public void Pause() // pause 버튼 push
    {
        Animation.SendMessage("PlayForward");
        Invoke("SetButton", 0.2f);
        isPause = true;
    }

    private void SetButton()
    {
        PalmUI.SendMessage("EnableButton");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Scene#2"); // 음악선택메뉴
    }
    public void QuitGame()
    {
        SceneManager.LoadScene("Scene#1"); // 맨처음 스타트메뉴
    }
}
