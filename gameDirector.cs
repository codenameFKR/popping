using UnityEngine;
using UnityEngine.UI;

public class gameDirector : MonoBehaviour
{
    public GameObject distance;
    public GameObject MyMaxScore;
    public GameObject FirstPlaceScore;
    public GameObject SecondPlaceScore;
    public GameObject ThirdPlaceScore;
    public GameObject resultPanel;
    public GameObject player;
    float maxY = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.distance = GameObject.Find("distance");
    }

    // Update is called once per frame
    void Update()
    {
        //ゲーム中の高さ表示
        float Ypos = player.transform.position.y + 4.0f;
        maxY = Mathf.Max(Ypos, maxY);
        this.distance.GetComponent<Text>().text = maxY.ToString("F2") + "km";

        //リザルト画面のスコア表示
        this.MyMaxScore.GetComponent<Text>().text = maxY.ToString("F2");
        float firstPlace = 0;
        float secondPlace = 0;
        float thirdPlace = 0;

        if(firstPlace < maxY)
        {
            thirdPlace = secondPlace;
            secondPlace = firstPlace;
            firstPlace = maxY;
        }
        else if(secondPlace < maxY)
        {
            thirdPlace = secondPlace;
            secondPlace = maxY;
        }
        else if(thirdPlace < maxY)
        {
            thirdPlace = maxY;
        }

        this.FirstPlaceScore.GetComponent<Text>().text = firstPlace.ToString("F2");
        this.SecondPlaceScore.GetComponent<Text>().text = secondPlace.ToString("F2");
        this.ThirdPlaceScore.GetComponent<Text>().text = thirdPlace.ToString("F2");
    }

    public void result()
    {
        resultPanel.SetActive(true);
    }
}
