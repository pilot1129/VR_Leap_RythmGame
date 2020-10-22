using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Set_Music_Info_Table : MonoBehaviour {
    public Image MI;
    public Text MN;
    public Text MA;
    
    // Use this for initialization
    void Start()
    {
        MI.sprite = Resources.Load<Sprite>("music0"+(SetSelectSceneData.s_index+1).ToString() +"Full");
        string name = PlayData.musicTitle;
        MN.text = name;
        string artist = PlayData.Artist;
        MA.text = artist;
    }
	
}
