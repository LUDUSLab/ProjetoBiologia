using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    float score;
    public Text scoreText;
    [HideInInspector]
    public int highScore; // para mostrar o high score é só pegar essa variável

    void Start()
    {
        highScore = PlayerPrefs.GetInt("highScore", 0); // recupera o high score que é armazenado localmente
    }

    void Update()
    {
        score += Time.deltaTime; // conta a pontuação de acordo com o tempo decorrido

        if (score > highScore) // salva o high score, caso este seja alcançado
        {
            highScore = (int)score;
            PlayerPrefs.SetInt("highScore", highScore);
        }

        if (scoreText) // Atualiza somente se encontrar um componente de texto
            scoreText.text = "Pontuação: " + (int)score;
    }

}
