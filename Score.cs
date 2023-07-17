using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static  Score instance;
    [SerializeField] private TextMeshProUGUI currentTXT;
    [SerializeField] private TextMeshProUGUI highTXT;
    private  int score=0;
    private  static int Hscore = 0;
    // Start is called before the first frame update
    private void Awake()
    {
       if(instance==null) instance = this;
    }
    void Start()
    {
        score = 0;
        currentTXT.text=score.ToString();
        highTXT.text=PlayerPrefs.GetInt("highScore",Hscore).ToString();
        UpdateHighScore();
        
    }
    private void UpdateHighScore()
    {
        if (score > PlayerPrefs.GetInt("highScore"))
        {
            Hscore = score;
            PlayerPrefs.GetInt("highScore", score);
            highTXT.text=score.ToString();
        }
    }

    // Update is called once per frame
    public void UpdateScore()
    {
        score++;
        currentTXT.text=score.ToString();
        UpdateHighScore();
    }
}
