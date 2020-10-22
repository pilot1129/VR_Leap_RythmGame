using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickSound : MonoBehaviour {

    public AudioSource sound;
    public AudioClip ClickSource;

    public void ClickSoundFunc()
    {
        sound.PlayOneShot(ClickSource);
    }
}

/* 사용법
 * EventSystem을 하나 만들어서, AudioSource와 ClickSound를 생성
 * ClickSound에 Sound에는 EventSystem의 AudioSource를 넣음
 * ClickSource에는 Click sound를 넣음
 * 해당 버튼에 EventTrigger을 만들고, Pointer Down을 생성
 * event의 ClickSound.clicksoundfunc를 호출.
 */
