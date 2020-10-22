using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //추가

public class NoteSpawn : MonoBehaviour {

    private NoteInfo cur_note = new NoteInfo();
    private NoteInfo note_buf = new NoteInfo(); //for simultaneous note
    private double beat;
    private float time = 0;
    private float delay_time = 0f;

    // Use this for initialization
    void Start()
    {
        beat = (double)60 / PlayData.BPM;
        Debug.Log(beat.ToString());

        cur_note = PlayData.note;
        note_buf = PlayData.note;
    }

    // Update is called once per frame
    void Update()
    {
        PlayData.PlayResult.accuracy = (PlayData.PlayResult.perfect + PlayData.PlayResult.great * 0.75f + PlayData.PlayResult.good * 0.5f + PlayData.PlayResult.bad * 0.25f) / PlayData.PlayResult.totalNote;

        if (PlayData.PlayResult.health <= 0)
            SceneManager.LoadScene("Scene#4-1");
        else if (cur_note == null)
        {
            delay_time += Time.deltaTime;

            if (delay_time > 7)
                SceneManager.LoadScene("Scene#4-1");
        }
        else if (PlayData.dataset && !PauseMenu.isPause)
		{
			time += Time.deltaTime;

            if (time >= beat * cur_note.timing)
			{
				if (note_buf != null && cur_note.timing == note_buf.timing)
				{
					MakeNote();
					cur_note = note_buf;
					MakeNote();

					cur_note = PlayData.note;
					note_buf = PlayData.note;
				}
				else
				{
					MakeNote();
					cur_note = note_buf;
					note_buf = PlayData.note;
				}
			}
		}
    }

    void MakeNote()
    {
        GameObject Note = ObjectPool.Instance.PopFromPool("Note");
        Note.transform.position = transform.position + new Vector3(cur_note.x, cur_note.y, cur_note.note_length);
        Note.transform.localScale = new Vector3(0.1f, cur_note.note_length, 0.1f);
        Note.SetActive(true);
    }
}
