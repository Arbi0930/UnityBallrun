using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public Text ScoreText;
    public Text highscoreText;
    public float highscore;
    public float score;
    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetFloat("Таны оноо: ");
        score = PlayerPrefs.GetFloat("Таны хамгийн өндөр оноо: ");
        ScoreText.text = "Таны оноо: " + score.ToString();
        highscoreText.text = "Хамгийн өндөр оноо: " + highscore.ToString();

        
    }
    public void restartLevel()
    {
        Application.LoadLevel(Application.loadedLevel);
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
