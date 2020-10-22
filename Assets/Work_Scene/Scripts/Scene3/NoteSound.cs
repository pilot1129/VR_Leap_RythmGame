using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSound : MonoBehaviour {
    public static Queue<AudioClip> audioList = new Queue<AudioClip>();
    AudioSource audio;
	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
	}
	
	void Update () {
        while (audioList.Count > 0)
        {
            audio.PlayOneShot(audioList.Dequeue());
        }
	}
}
