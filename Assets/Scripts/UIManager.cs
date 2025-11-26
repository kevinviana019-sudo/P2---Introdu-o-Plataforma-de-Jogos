using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreText;
    public Text messageText;

    private int score = 0;

    void Start()
    {
        UpdateScoreText();
        messageText.text = "Bem vindo ao jogo!";
    }

    public void AddScore()
    {
        score++;
        UpdateScoreText();
        messageText.text = "Você clicou no botao!";
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }

    public void ChangeMessage(string newMessage)
    {
        messageText.text = newMessage;
    }
}
