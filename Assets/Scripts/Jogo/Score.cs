using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [HideInInspector]
    public static float score, cont, addzinho = 2000;
    public Text scoreText;
    [HideInInspector]
    public static int highScore; // para mostrar o high score é só pegar essa variável


    void Start()
    {
<<<<<<< HEAD
        nomeFase = SceneManager.GetActiveScene().name;
=======
>>>>>>> origin/master
        score = 0;
        cont = 0;
    }

    void Update()
    {
<<<<<<< HEAD
		//checkFase = PlayerPrefs.GetString("nomeFase");
=======
>>>>>>> origin/master
		cont += Time.deltaTime ; // conta a pontuação de acordo com o tempo decorrido

        if (scoreText) // Atualiza somente se encontrar um componente de texto
            scoreText.text = "Pontuação: " + (int)score ;
    }

	public void Addscore()
	{
		score += addzinho *44;
	}

    public static void FinalScore()
    {
        score = score / cont;
<<<<<<< HEAD
        highScore = PlayerPrefs.GetInt("recorde", 0); // recupera o high score que é armazenado localmente
		highScore2 = PlayerPrefs.GetInt("recorde2", 0);
		highScore3 = PlayerPrefs.GetInt("recorde3", 0);

		if ( nomeFase == "Fase1")
		{
			if (score > highScore) // salva o high score, caso este seja alcançado
			{
				highScore = (int)score;
				PlayerPrefs.SetInt("recorde", highScore);
			}
		}
		else if ( nomeFase == "CenarioBonito")
		{
			if (score > highScore2) // salva o high score, caso este seja alcançado
			{
				highScore2 = (int)score;
				PlayerPrefs.SetInt("recorde2", highScore2);
			}
		}
		else if ( nomeFase == "Fase3")
		{
			if (score > highScore3) // salva o high score, caso este seja alcançado
			{
				highScore3 = (int)score;
				PlayerPrefs.SetInt("recorde3", highScore3);
			}
		}
=======
        highScore = PlayerPrefs.GetInt("highScore", 0); // recupera o high score que é armazenado localmente
        if (score > highScore) // salva o high score, caso este seja alcançado
        {
            highScore = (int)score;
            PlayerPrefs.SetInt("highScore", highScore);
        }
>>>>>>> origin/master

    }

}
