using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScorePanel : MonoBehaviour {
    public Text highScore;
    Image ScoreImage;
    
    public Sprite F;
    public Sprite S;
    public Sprite A;
    public Sprite B;
    public Sprite C;

    void Start()
    {
        ScoreImage = GetComponent<Image>();
        highScore.text = (PlayData.High_score > PlayData.PlayResult.cur_score) ? PlayData.High_score.ToString() : PlayData.PlayResult.cur_score.ToString();
        PlayData.High_score = int.Parse(highScore.text);

        if ((PlayData.PlayResult.health > 0) && (PlayData.PlayResult.accuracy >= 0.9))
        {
            ScoreImage.sprite = S;
        }
        else if ((PlayData.PlayResult.health > 0) && (PlayData.PlayResult.accuracy >= 0.85))
        {
            ScoreImage.sprite = A;
        }
        else if ((PlayData.PlayResult.health > 0) && (PlayData.PlayResult.accuracy >= 0.75))
        {
            ScoreImage.sprite = B;
        }
        else if ((PlayData.PlayResult.health > 0) && (PlayData.PlayResult.accuracy >= 0.40))
        {
            ScoreImage.sprite = C;
        }
        else
        {
            ScoreImage.sprite = F;
        }
    }
}
