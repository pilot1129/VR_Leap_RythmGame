using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour {

    public GameObject soundControlButton; // 버튼이건 이미지건 넣으면 됨
	
    public void SoundControl()
    {
        if (AudioListener.pause == true) // 정지상태라면
            AudioListener.pause = false; // 재생
        else // 재생중이라면
            AudioListener.pause = true; // 일시정지
    }
}
