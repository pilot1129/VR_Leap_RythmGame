using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetInGameData {

	private static string defaultpath = @"Assets\Work_Scene\Resources\noteinfo_txt\";
	private static float temp_x;
	private static float temp_y;
	private static float temp_length;
	private static float temp_timing;

    public static void Init()
    {
        PlayData.queue = new Queue<NoteInfo>();

        ReadData();
        PlayData.musicTitle = SetSelectSceneData.s_Songname;
        PlayData.BPM = SetSelectSceneData.s_SongBPM;
        PlayData.Level = SetSelectSceneData.s_SongLevel;

        PlayData.PlayResult = new PlayInfo();
        PlayData.dataset = true;
    }

    static void ReadData()
	{
        if (SetSelectSceneData.Globaldata[SetSelectSceneData.s_index].Notequeue.Count == 0)
        {
            string path;
            path = defaultpath + SetSelectSceneData.s_Songname + ".txt";

            string[] temp = System.IO.File.ReadAllLines(path);
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] != "")
                {
                    //Debug.Log(temp[i]);
                    string[] splited_string = temp[i].Split(',');
                    /*
                    Debug.Log(splited_string[0]);
                    Debug.Log(splited_string[1]);
                    Debug.Log(splited_string[2]);
                    Debug.Log(splited_string[3]);
                    */
                    Fracconvert(splited_string);

                    NoteInfo tempnote = new NoteInfo();
                    tempnote.x = temp_x;
                    tempnote.y = temp_y;
                    tempnote.note_length = temp_length;
                    tempnote.timing = temp_timing;

                    PlayData.note = tempnote;

                    // 현재 선택된 곡의 이름을 비교해서 글로벌 음악정보의 노트큐에 집어넣기
                    /*
                    for (int j = 0; j < SetSelectSceneData.Globaldata.Length; j++)
                        if (SetSelectSceneData.Globaldata[j].Name == SetSelectSceneData.s_Songname)
                        {
                            SetSelectSceneData.Globaldata[j].EnqueueNote(tempnote);
                            break;
                        }
                    */
                }
            }
            SetSelectSceneData.Globaldata[SetSelectSceneData.s_index].Notequeue = PlayData.queue;
        }
        else
        {
            PlayData.queue = SetSelectSceneData.Globaldata[SetSelectSceneData.s_index].Notequeue;
        }
	}

	static void Fracconvert(string[] inputstr)
	{
		double numer, denom;

		string[] tempfrag;

		for (int i = 0; i < inputstr.Length; i++)
		{
			if (inputstr[i].Contains("/"))
			{
				tempfrag = inputstr[i].Split('/');
				numer = Convert.ToDouble(tempfrag[0]);
				denom = Convert.ToDouble(tempfrag[1]);
				inputstr[i] = ((float)(numer / denom)).ToString();
			}

			switch (i)
			{
				case 0:
					temp_x = float.Parse(inputstr[i]);
					break;
				case 1:
					temp_y = float.Parse(inputstr[i]);
					break;
				case 2:
					temp_length = float.Parse(inputstr[i]);
					break;
				case 3:
					temp_timing = float.Parse(inputstr[i]);
					break;
				default:
					break;
			}
		}
	}
}
