using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Demo : MonoBehaviour {

    public static AudioSource audios; // AudioSource passive 지정
    Slider slider; // 슬라이더 지정

    public Text TimeText; // 시간 표시 텍스트 받아옴

	private float time = 0;
	private bool datasetflag = false;

	// Use this for initialization
	void Start () {
        audios = GetComponent<AudioSource>();
        slider = GetComponent<Slider>();

        audios.clip = SetSelectSceneData.Globaldata[SetSelectSceneData.s_index].Audioinfo; // 재지정
        audios.volume = 0.5f;

		slider.minValue = 0;
        slider.maxValue = audios.clip.length; // 노래길이 = 슬라이더 길이
	}
	
	// Update is called once per frame
	void Update () {
		if(PlayData.dataset && !PauseMenu.isPause)
			time += Time.deltaTime;

		if (PlayData.dataset && !datasetflag && time >= 3.5f)
		{
			audios.Play();
			datasetflag = true;
		}

        if (PauseMenu.isPause)
            audios.Pause();
        else
            audios.UnPause();
        
        slider.value = audios.time;
        int AudioTimeMin = (int)audios.time / 60;
        int AudioTimeSec = (int)audios.time % 60;
        int SongLengthMin = (int)audios.clip.length / 60;
        int SongLengthSec = (int)audios.clip.length % 60;
        TimeText.text = AudioTimeMin.ToString("0") + ":" + AudioTimeSec.ToString("0") + " / " + SongLengthMin.ToString("0") + ":" + SongLengthSec.ToString("0");
    }

    public void MovePosition()
    {
        audios.time = slider.value;
    }
}

/* 사용법
 * Slider을 생성하고, Slider에 AudioSource와 Demo Script 삽입
 * Song과 TimeText를 삽입하고 걍 재생.
 * 지가 알아서됨 ㅅㄱ
 */