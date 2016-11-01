using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverButtons : MonoBehaviour {

    //public string tryAgain;
    public Text highScoreText;
    public Text scoreText;
    public GameObject hudSair;

    void Start()
    {
        Score.FinalScore();
        ViewScore();
    }

	public void Menu()
	{
		SceneManager.LoadScene ("Menu");
	}

	public void CenarioBonito()
	{

		SceneManager.LoadScene ("CenarioBonito");
	}

    public void Sair()
    {
        hudSair.SetActive(true);
    }

    public void Sim()
    {
        Application.Quit();
    }

    public void Nao()
    {
        hudSair.SetActive(false);
    }

    void ViewScore()
    {
        highScoreText.text = PlayerPrefs.GetInt("highScore").ToString();
        int localScore = (int)Score.score;
        scoreText.text = localScore.ToString();
    }

}
