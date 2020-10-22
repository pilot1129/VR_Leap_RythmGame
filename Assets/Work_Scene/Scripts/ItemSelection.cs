using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSelection : MonoBehaviour {

    //public List<List<Sprite>> ItemList = new List<List<Sprite>>();
    //Dictionary<int, Sprite> ItemList = new Dictionary<int, Sprite>();

    public List<Image> SelectionImageList = new List<Image>(); // 이미지
    public List<Text> SelectionNameList = new List<Text>(); // 곡명
    public List<Text> SelectionArtistList = new List<Text>(); // 아티스트
    public List<Text> SelectionDifficultyList = new List<Text>(); // 난이도(Lv)
    public List<Image> SelectionScoreList = new List<Image>(); // 점수(S/A/B/C/F)

    // ImageList
    public List<Sprite> ItemList0 = new List<Sprite>();
    public List<Sprite> ItemList1 = new List<Sprite>();
    public List<Sprite> ItemList2 = new List<Sprite>();
    public List<Sprite> ItemList3 = new List<Sprite>();
    public List<Sprite> ItemList4 = new List<Sprite>();
    public List<Sprite> ItemList5 = new List<Sprite>();
    public List<Sprite> ItemList6 = new List<Sprite>();

    //NameList
    public List<string> NameList0 = new List<string>();
    public List<string> NameList1 = new List<string>();
    public List<string> NameList2 = new List<string>();
    public List<string> NameList3 = new List<string>();
    public List<string> NameList4 = new List<string>();
    public List<string> NameList5 = new List<string>();
    public List<string> NameList6 = new List<string>();
    //ArtistList
    public List<string> ArtistList0 = new List<string>();
    public List<string> ArtistList1 = new List<string>();
    public List<string> ArtistList2 = new List<string>();
    public List<string> ArtistList3 = new List<string>();
    public List<string> ArtistList4 = new List<string>();
    public List<string> ArtistList5 = new List<string>();
    public List<string> ArtistList6 = new List<string>();
    //DifficultyList
    public List<string> DifficultyList0 = new List<string>();
    public List<string> DifficultyList1 = new List<string>();
    public List<string> DifficultyList2 = new List<string>();
    public List<string> DifficultyList3 = new List<string>();
    public List<string> DifficultyList4 = new List<string>();
    public List<string> DifficultyList5 = new List<string>();
    public List<string> DifficultyList6 = new List<string>();
    //ScoreList
    public List<Sprite> ScoreList0 = new List<Sprite>();
    public List<Sprite> ScoreList1 = new List<Sprite>();
    public List<Sprite> ScoreList2 = new List<Sprite>();
    public List<Sprite> ScoreList3 = new List<Sprite>();
    public List<Sprite> ScoreList4 = new List<Sprite>();
    public List<Sprite> ScoreList5 = new List<Sprite>();
    public List<Sprite> ScoreList6 = new List<Sprite>();


    //public Image SelectionImage0;
    private int ItemSpot = 0;

    public void RightSelection()
    {
        if(ItemSpot < ItemList0.Count -1)
        {
            ItemSpot++;
            for(int i = 0; i<7; i++)
            {
                switch (i)
                {
                    case 0:
                        SelectionImageList[i].sprite = ItemList0[ItemSpot];
                        SelectionNameList[i].text = NameList0[ItemSpot];
                        SelectionArtistList[i].text = ArtistList0[ItemSpot];
                        SelectionDifficultyList[i].text = DifficultyList0[ItemSpot];
                        SelectionScoreList[i].sprite = ScoreList0[ItemSpot];
                        break;
                    case 1:
                        SelectionImageList[i].sprite = ItemList1[ItemSpot];
                        SelectionNameList[i].text = NameList1[ItemSpot];
                        SelectionArtistList[i].text = ArtistList1[ItemSpot];
                        SelectionDifficultyList[i].text = DifficultyList1[ItemSpot];
                        SelectionScoreList[i].sprite = ScoreList1[ItemSpot];
                        break;
                    case 2:
                        SelectionImageList[i].sprite = ItemList2[ItemSpot];
                        SelectionNameList[i].text = NameList2[ItemSpot];
                        SelectionArtistList[i].text = ArtistList2[ItemSpot];
                        SelectionDifficultyList[i].text = DifficultyList2[ItemSpot];
                        SelectionScoreList[i].sprite = ScoreList2[ItemSpot];
                        break;
                    case 3:
                        SelectionImageList[i].sprite = ItemList3[ItemSpot];
                        SelectionNameList[i].text = NameList3[ItemSpot];
                        SelectionArtistList[i].text = ArtistList3[ItemSpot];
                        SelectionDifficultyList[i].text = DifficultyList3[ItemSpot];
                        SelectionScoreList[i].sprite = ScoreList3[ItemSpot];
                        break;
                    case 4:
                        SelectionImageList[i].sprite = ItemList4[ItemSpot];
                        SelectionNameList[i].text = NameList4[ItemSpot];
                        SelectionArtistList[i].text = ArtistList4[ItemSpot];
                        SelectionDifficultyList[i].text = DifficultyList4[ItemSpot];
                        SelectionScoreList[i].sprite = ScoreList4[ItemSpot];
                        break;
                    case 5:
                        SelectionImageList[i].sprite = ItemList5[ItemSpot];
                        SelectionNameList[i].text = NameList5[ItemSpot];
                        SelectionArtistList[i].text = ArtistList5[ItemSpot];
                        SelectionDifficultyList[i].text = DifficultyList5[ItemSpot];
                        SelectionScoreList[i].sprite = ScoreList5[ItemSpot];
                        break;
                    case 6:
                        SelectionImageList[i].sprite = ItemList6[ItemSpot];
                        SelectionNameList[i].text = NameList6[ItemSpot];
                        SelectionArtistList[i].text = ArtistList6[ItemSpot];
                        SelectionDifficultyList[i].text = DifficultyList6[ItemSpot];
                        SelectionScoreList[i].sprite = ScoreList6[ItemSpot];
                        break;
                }
            } 
        }
        /*
        if(ItemSpot < ItemList.Count-1)
        {
            ItemSpot++;
            SelectionImage0.sprite = ItemList[ItemSpot];
        }
        */
    }
    public void LeftSelection()
    {
        if (ItemSpot >0)
        {
            ItemSpot--;
            for (int i = 0; i < 7; i++)
            {
                switch (i)
                {
                    case 0:
                        SelectionImageList[i].sprite = ItemList0[ItemSpot];
                        SelectionNameList[i].text = NameList0[ItemSpot];
                        SelectionArtistList[i].text = ArtistList0[ItemSpot];
                        SelectionDifficultyList[i].text = DifficultyList0[ItemSpot];
                        SelectionScoreList[i].sprite = ScoreList0[ItemSpot];
                        break;
                    case 1:
                        SelectionImageList[i].sprite = ItemList1[ItemSpot];
                        SelectionNameList[i].text = NameList1[ItemSpot];
                        SelectionArtistList[i].text = ArtistList1[ItemSpot];
                        SelectionDifficultyList[i].text = DifficultyList1[ItemSpot];
                        SelectionScoreList[i].sprite = ScoreList1[ItemSpot];
                        break;
                    case 2:
                        SelectionImageList[i].sprite = ItemList2[ItemSpot];
                        SelectionNameList[i].text = NameList2[ItemSpot];
                        SelectionArtistList[i].text = ArtistList2[ItemSpot];
                        SelectionDifficultyList[i].text = DifficultyList2[ItemSpot];
                        SelectionScoreList[i].sprite = ScoreList2[ItemSpot];
                        break;
                    case 3:
                        SelectionImageList[i].sprite = ItemList3[ItemSpot];
                        SelectionNameList[i].text = NameList3[ItemSpot];
                        SelectionArtistList[i].text = ArtistList3[ItemSpot];
                        SelectionDifficultyList[i].text = DifficultyList3[ItemSpot];
                        SelectionScoreList[i].sprite = ScoreList3[ItemSpot];
                        break;
                    case 4:
                        SelectionImageList[i].sprite = ItemList4[ItemSpot];
                        SelectionNameList[i].text = NameList4[ItemSpot];
                        SelectionArtistList[i].text = ArtistList4[ItemSpot];
                        SelectionDifficultyList[i].text = DifficultyList4[ItemSpot];
                        SelectionScoreList[i].sprite = ScoreList4[ItemSpot];
                        break;
                    case 5:
                        SelectionImageList[i].sprite = ItemList5[ItemSpot];
                        SelectionNameList[i].text = NameList5[ItemSpot];
                        SelectionArtistList[i].text = ArtistList5[ItemSpot];
                        SelectionDifficultyList[i].text = DifficultyList5[ItemSpot];
                        SelectionScoreList[i].sprite = ScoreList5[ItemSpot];
                        break;
                    case 6:
                        SelectionImageList[i].sprite = ItemList6[ItemSpot];
                        SelectionNameList[i].text = NameList6[ItemSpot];
                        SelectionArtistList[i].text = ArtistList6[ItemSpot];
                        SelectionDifficultyList[i].text = DifficultyList6[ItemSpot];
                        SelectionScoreList[i].sprite = ScoreList6[ItemSpot];
                        break;
                }
            }
        }
        /*
        if (ItemSpot < ItemList.Count - 1)
        {
            ItemSpot--;
            SelectionImage0.sprite = ItemList[ItemSpot];
        }
        */
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
