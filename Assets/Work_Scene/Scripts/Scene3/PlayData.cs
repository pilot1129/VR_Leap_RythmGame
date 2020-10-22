using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayData {
    private static string musicName = "";
    private static string artist = "";
    private static string index;
    private static Queue<NoteInfo> noteQueue = new Queue<NoteInfo>();
    private static int bpm = 90;

    private static int level = 0;
    private static int high_score = 0;
    private static PlayInfo playResult = new PlayInfo();

    private static bool isdataset = false;

    public static string Index
    {
        get
        {
            return index;
        }
        set
        {
            index = value;
        }
    }
    public static string musicTitle
    {
        get
        {
            return musicName;
        }
        set
        {
            musicName = value;
        }
    }

    public static NoteInfo note
    {
        get
        {
            if (noteQueue.Count > 0)
                return noteQueue.Dequeue();
            else
                return null;
        }
        set
        {
            noteQueue.Enqueue(value);
        }
    }

	public static Queue<NoteInfo> queue
	{
		get
		{
			return noteQueue;
		}
		set
		{
			noteQueue = value;
		}
	}

	public static int BPM
    {
        get
        {
            return bpm;
        }

        set
        {
            bpm = value;
        }
    }

	public static bool dataset
	{
		get
		{
			return isdataset;
		}
		set
		{
			isdataset = value;
		}
	}

    public static int High_score
    {
        get
        {
            return high_score;
        }

        set
        {
            high_score = value;
        }
    }

    public static string Artist
    {
        get
        {
            return artist;
        }

        set
        {
            artist = value;
        }
    }

    public static int Level
    {
        get
        {
            return level;
        }

        set
        {
            level = value;
        }
    }

    public static PlayInfo PlayResult
    {
        get
        {
            return playResult;
        }

        set
        {
            playResult = value;
        }
    }
}

public class PlayInfo {
    public float health = 100f;
    public int cur_score = 0;
    public float accuracy = 0;

    public int totalNote = 0;
    public int combo = 0;
    public int maxCombo = 0;
    public int perfect = 0;
    public int great = 0;
    public int good = 0;
    public int bad = 0;
    public int miss = 0;
}