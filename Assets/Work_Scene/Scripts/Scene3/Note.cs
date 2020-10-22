using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour {
    public string poolItemName = "Note";
    public bool isTouch = false;
    private float noteSpeed = 1f;

    public GameObject TouchParticle = null;
    public AudioClip TouchSource;
    public AudioClip LongSource;

    private bool setNavigate = false;

    GameObject NotePath = null;
    GameObject NoteThreshold = null;

    // Update is called once per frame
    void Update()
    {
        if (!PauseMenu.isPause)
        {
            float noteTopPosition = transform.position.z - transform.localScale.y;

            transform.Translate(0, -noteSpeed * Time.deltaTime, 0);
            if (noteTopPosition < 0.5 && setNavigate == true)
            {
                ObjectPool.Instance.PushToPool("NotePath", NotePath);
                ObjectPool.Instance.PushToPool("NoteThreshold", NoteThreshold);
                setNavigate = false;
            }
            else if (!isTouch && noteTopPosition > 0.5 && noteTopPosition < 2)
                SetNoteNavigate();

            if (noteTopPosition <= 0.35)
                CollideEvent();
            else if (isTouch == true)
            { //z축이 얼마 이하일 경우, 혹은 사람이 손을 댔을 경우
                Instantiate(TouchParticle, new Vector3(transform.position.x, transform.position.y, noteTopPosition), new Quaternion(0f, 0f, 0f, 0f));
                if (setNavigate == true)
                {
                    ObjectPool.Instance.PushToPool("NotePath", NotePath);
                    ObjectPool.Instance.PushToPool("NoteThreshold", NoteThreshold);
                    setNavigate = false;
                }
                CollideEvent(); //점수 및 콤보 증가 이벤트 추가
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.ToString() == "Contact Fingerbone (UnityEngine.GameObject)")
            isTouch = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.ToString() == "Contact Fingerbone (UnityEngine.GameObject)")
            isTouch = false;
    }

    private void CollideEvent()
    {
        setScore();
        if (transform.localScale.y < 0.01)
        {
            if (isTouch)
                NoteSound.audioList.Enqueue(TouchSource);
            isTouch = false;
            ObjectPool.Instance.PushToPool(poolItemName, gameObject);
        }
        else
        {
            if(isTouch)
                NoteSound.audioList.Enqueue(LongSource);
            transform.localScale += new Vector3(0, -noteSpeed * Time.deltaTime - 0.05f, 0);
        }
    }

    private void SetNoteNavigate()
    {
        float noteTopPosition = transform.position.z - transform.localScale.y;
        if (setNavigate == false)
        {
            NotePath = ObjectPool.Instance.PopFromPool("NotePath");
            NoteThreshold = ObjectPool.Instance.PopFromPool("NoteThreshold");
            NotePath.SetActive(true);
            NoteThreshold.SetActive(true);
            NotePath.transform.localScale = new Vector3(0.001f, (noteTopPosition - 0.5f) / 2, 0.001f); // TODO:
            NoteThreshold.transform.position = new Vector3(transform.position.x, transform.position.y, 0.5f);
            NoteThreshold.transform.localScale = new Vector3(0, 0, 0);
            setNavigate = true;
        }

        if (NoteThreshold.transform.localScale.x < 0.02f)
            NoteThreshold.transform.localScale += new Vector3(0.001f, 0.001f, 0);

        NotePath.transform.position = new Vector3(transform.position.x, transform.position.y, (noteTopPosition - 0.5f) / 2 + 0.5f); // TODO: 롱노트시 에러
        NotePath.transform.localScale += new Vector3(0, -noteSpeed * Time.deltaTime, 0) / 2;
    }

    private void setScore()
    {
        GameObject NoteJudge = null;
        float noteTopPosition = transform.position.z - transform.localScale.y;
        PlayData.PlayResult.combo++;
        float pos = Mathf.Abs(noteTopPosition - 0.5f);
        int scoreBonus = 1 + (int)Mathf.Log(2f, PlayData.PlayResult.combo);
        int baseScore = 100 * scoreBonus;

        if (isTouch && pos <= 0.02f * noteSpeed) //perfect
        {
            NoteJudge = ObjectPool.Instance.PopFromPool("Note_Perfect");
            PlayData.PlayResult.cur_score += baseScore;
            PlayData.PlayResult.perfect++;
            PlayData.PlayResult.health++;
        }
        else if (isTouch && pos <= 0.045f * noteSpeed) //great
        {
            NoteJudge = ObjectPool.Instance.PopFromPool("Note_Great");
            PlayData.PlayResult.cur_score += (int)(baseScore * 0.75);
            PlayData.PlayResult.great++;
            PlayData.PlayResult.health++;
        }
        else if (isTouch && pos <= 0.075f * noteSpeed) // good
        {
            NoteJudge = ObjectPool.Instance.PopFromPool("Note_Good");
            PlayData.PlayResult.cur_score += (int)(baseScore * 0.5);
            PlayData.PlayResult.good++;
            PlayData.PlayResult.health++;
        }
        else if (isTouch && pos <= 0.15f * noteSpeed) // bad
        {
            NoteJudge = ObjectPool.Instance.PopFromPool("Note_Bad");
            PlayData.PlayResult.cur_score += (int)(baseScore * 0.25);
            PlayData.PlayResult.bad++;
            PlayData.PlayResult.health--;
        }
        else // miss
        {
            NoteJudge = ObjectPool.Instance.PopFromPool("Note_Miss");
            PlayData.PlayResult.combo = 0;
            PlayData.PlayResult.miss++;
            PlayData.PlayResult.health -= 3;
        }

        NoteJudge.transform.position = new Vector3(transform.position.x, transform.position.y, noteTopPosition);
        NoteJudge.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
        NoteJudge.SetActive(true);

        PlayData.PlayResult.maxCombo = (PlayData.PlayResult.maxCombo > PlayData.PlayResult.combo) ? PlayData.PlayResult.maxCombo : PlayData.PlayResult.combo;
        PlayData.PlayResult.totalNote++;
    }
}