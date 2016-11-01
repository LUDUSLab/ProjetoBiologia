using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverButtons : MonoBehaviour {

    public string tryAgain;
    public Text highScoreText;
    public Text scoreText; 

    void Start()
    {
        Score.FinalScore();
        ViewScore();
    }

	public void Menu()
	{
		SceneManager.LoadScene ("Menu");
	}

	public void TryAgain()
	{

		SceneManager.LoadScene (tryAgain);
	}

    void ViewScore()
    {
        highScoreText.text = PlayerPrefs.GetInt("highScore").ToString();
        int localScore = (int)Score.score;
        scoreText.text = localScore.ToString();
    }

}
