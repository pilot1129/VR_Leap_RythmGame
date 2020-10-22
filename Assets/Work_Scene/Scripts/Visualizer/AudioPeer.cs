using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(AudioSource))]
public class AudioPeer : MonoBehaviour {
    AudioSource _audioSource;
    public static float[] _samples = new float[1024]; // instantiate 참조

    // Use this for initialization
    void Start () {
        _audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        GetSpectrumAudioSource(); // 원형 생성
       // MakeFrequencyBands(); // 밴드 생성
	}

    void GetSpectrumAudioSource()
    {
        //_audioSource.GetSpectrumData(_samples, 0, FFTWindow.Blackman);
        _audioSource.GetSpectrumData(_samples, 0, FFTWindow.Rectangular);
    }

}
