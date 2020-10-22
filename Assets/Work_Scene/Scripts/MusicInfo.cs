using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicInfo {
	public string Name { get; set; }
	public string Artist { get; set; }
	public int Level { get; set; }
	public int Bpm { get; set; }
	public AudioClip Audioinfo { get; set; }
	public Sprite Spriteinfo { get; set; }
    public string Index { get; set; }
    private Queue<NoteInfo> notequeue;

	public MusicInfo()
	{
		Name = "";
		Artist = "";
		Level = 0;
		Bpm = 0;
        Index = "" ;                                  // 희주가 추가함
		Audioinfo = new AudioClip();
		Spriteinfo = new Sprite();
		notequeue = new Queue<NoteInfo>();
	}

	// queue deep copy get set
	public Queue<NoteInfo> Notequeue
	{
		get
		{
			Queue<NoteInfo> cqueue = new Queue<NoteInfo>();
			NoteInfo[] temparr = notequeue.ToArray();
			for (int i = 0; i < temparr.Length; i++)
				cqueue.Enqueue(temparr[i].Clone());
			return cqueue;
		}
		set
		{
			Queue<NoteInfo> cqueue = new Queue<NoteInfo>();
			NoteInfo[] temparr = value.ToArray();
			for (int i = 0; i < temparr.Length; i++)
				cqueue.Enqueue(temparr[i].Clone());
			notequeue = cqueue;
		}
	}

	public void EnqueueNote(NoteInfo n)
	{
		notequeue.Enqueue(n);
	}
}
