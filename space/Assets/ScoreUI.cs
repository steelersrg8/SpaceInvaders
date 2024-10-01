using UnityEngine;
using System.Collections;

public class ScoreUI : MonoBehaviour
{

    public static int score = 0;
    public static int highscore = 0;
    public GameObject scorekeeper;
    static ScoreUI instance;
    public Component font;
    void Start()
    {
        DontDestroyOnLoad(scorekeeper);
        score = 0;
        highscore = PlayerPrefs.GetInt("highscore", 0);
        PlayerPrefs.SetInt("highscore", highscore);
        PlayerPrefs.Save();
    }

    public static void AddPoint()
    {
        score++;

        if (score > highscore)
        {
            highscore = score;
        }



    }

}