using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    static private string nomeFase, checkFase;
    [HideInInspector]
    public static float score, cont, addzinho = 2000;
    public Text scoreText;
    [HideInInspector]
    public static int highScore = 0, highScore2 = 0, highScore3 = 0; // para mostrar o high score é só pegar essa variável


    void Start()
    {
        nomeFase = SceneManager.GetActiveScene().name;
        score = 0;
        cont = 0;
    }

    void Update()
    {
        //checkFase = PlayerPrefs.GetString("nomeFase");
        cont += Time.deltaTime; // conta a pontuação de acordo com o tempo decorrido

        if (scoreText) // Atualiza somente se encontrar um componente de texto
            scoreText.text = "Pontuação: " + (int)score;
    }

    public void Addscore()
    {
        score += addzinho * 44;
    }

    public static void FinalScore()
    {
        score = score / cont;
        highScore = PlayerPrefs.GetInt("recorde", 0); // recupera o high score que é armazenado localmente
        highScore2 = PlayerPrefs.GetInt("recorde2", 0);
        highScore3 = PlayerPrefs.GetInt("recorde3", 0);

        if (nomeFase == "Fase1")
        {
            if (score > highScore) // salva o high score, caso este seja alcançado
            {
                highScore = (int)score;
                PlayerPrefs.SetInt("recorde", highScore);
            }
        }
        else if (nomeFase == "CenarioBonito")
        {
            if (score > highScore2) // salva o high score, caso este seja alcançado
            {
                highScore2 = (int)score;
                PlayerPrefs.SetInt("recorde2", highScore2);
            }
        }
        else if (nomeFase == "Fase3")
        {
            if (score > highScore3) // salva o high score, caso este seja alcançado
            {
                highScore3 = (int)score;
                PlayerPrefs.SetInt("recorde3", highScore3);
            }
        }

    }

}
