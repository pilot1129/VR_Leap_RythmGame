using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetSelectSceneData : MonoBehaviour {



	public const int songcount = 3;
	private string path = @"Assets\Resources\";

	public AudioClip[] Songs = new AudioClip[songcount];

	// 글로벌 데이터
	private static MusicInfo[] globaldataarr = new MusicInfo[songcount];

	// 선택된 변수값을 담는 곳
	public static int s_index { get; set; }
	public static string s_Artist { get; set; }
	public static string s_Songname { get; set; }
	public static int s_SongLevel { get; set; }
	public static int s_SongBPM { get; set; }
    
	// Use this for initialization
	void Start () {
		LoadData();
		SetPanel();
	}
	
	void LoadData()
	{
        /*
		s_index = 0;
		s_Artist = "Alan Walker";
		s_Songname = "Fade";
		s_SongLevel = 3;
		s_SongBPM = 90;
        */

		for (int i = 0; i < songcount; i++)
		{
			globaldataarr[i] = new MusicInfo();
			string temppath = path + "music0" + (i + 1).ToString() + ".txt";
			string[] temp = System.IO.File.ReadAllLines(temppath);

			globaldataarr[i].Artist = temp[0];
			globaldataarr[i].Name = temp[1];
			globaldataarr[i].Bpm = int.Parse(temp[2]);
			globaldataarr[i].Level = int.Parse(temp[3]);
			globaldataarr[i].Spriteinfo = Resources.Load<Sprite>("music0" + (i + 1).ToString() + "image");
			globaldataarr[i].Audioinfo = Songs[i];
            string INDEX = (i + 1).ToString();
            globaldataarr[i].Index = INDEX;
        }
	}

	void SetPanel()
	{
		GameObject temp = null;
		GameObject.Find("Select_Canvas_UI").SetActive(false);

		for (int i = 0; i < songcount; i++)
		{
			temp = GameObject.Find("music0" + (i + 1).ToString());
			if (temp != null)
			{
				temp.transform.Find("Music_Name").GetComponent<Text>().text = globaldataarr[i].Name;
				temp.transform.Find("Music_Artist").GetComponent<Text>().text = globaldataarr[i].Artist;
				temp.transform.Find("Music_Image").GetComponent<Image>().sprite = globaldataarr[i].Spriteinfo;
				//temp.transform.Find("Music_Difficulty").GetComponent<Image>().sprite = globaldataarr[i].Spriteinfo;
				//temp.transform.Find("Music_Score").GetComponent<Image>().sprite = globaldataarr[i].Spriteinfo;
			}
		}
	}

	public static MusicInfo[] Globaldata
	{ get { return globaldataarr; } set { globaldataarr = value; } }
}
