using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class SelectMusic : MonoBehaviour {
    public Image ShowImage;

    public GameObject cubeOneObject;

    public GameObject music01;
    public GameObject music02;
    public GameObject music03;
    public GameObject music04;
    public GameObject music05;

    private Select_Canvas_UI OtherScriptToAccess;

    public Image MusicScore01;
    public Image MusicScore02;
    public Image MusicScore03;
    public Image MusicScore04;
    public Image MusicScore05;


    public void ShowWindows(Image m_Canvas)
    {
        UnActive();
        ShowImage.sprite = Resources.Load<Sprite>(m_Canvas.name + "Full");
        Sprite MusicScoreImage;
        if (m_Canvas.name == "music01")
        {
            MusicScoreImage = MusicScore01.sprite;
        }
        else if (m_Canvas.name == "music02")
        {
            MusicScoreImage = MusicScore02.sprite;
        }
        else if (m_Canvas.name == "music03")
        {
            MusicScoreImage = MusicScore03.sprite;
        }
        else if (m_Canvas.name == "music04")
        {
            MusicScoreImage = MusicScore04.sprite;
        }
        else
        {
            MusicScoreImage = MusicScore05.sprite;              // 할당 안했다고 떠서 그냥 함
        }


        cubeOneObject.SetActive(true);

        OtherScriptToAccess = cubeOneObject.GetComponent<Select_Canvas_UI>();

        OtherScriptToAccess.enabled = true;

		int tempindex = int.Parse(m_Canvas.name[6].ToString()) - 1; // music01에서 1을 가져와 0번째 인덱스로 변환

		string tempartist = SetSelectSceneData.Globaldata[tempindex].Artist; // 맞는 배열 인덱스의 값을 가져옴
		string tempsongname = SetSelectSceneData.Globaldata[tempindex].Name;
		int tempsonglevel = SetSelectSceneData.Globaldata[tempindex].Level;
		int tempsongbpm = SetSelectSceneData.Globaldata[tempindex].Bpm;

		OtherScriptToAccess.Call_Update(ShowImage, tempsongname, tempartist,MusicScoreImage);

		SetSelectSceneData.s_index = tempindex;
		SetSelectSceneData.s_Artist = tempartist;
		SetSelectSceneData.s_Songname = tempsongname;
		SetSelectSceneData.s_SongLevel = tempsonglevel;
		SetSelectSceneData.s_SongBPM = tempsongbpm;
    }

    public void UnActive()
    {
        music01.GetComponent<BoxCollider>().enabled = false;
        music02.GetComponent<BoxCollider>().enabled = false;
        music03.GetComponent<BoxCollider>().enabled = false;
        music04.GetComponent<BoxCollider>().enabled = false;
        music05.GetComponent<BoxCollider>().enabled = false;

    }
}
