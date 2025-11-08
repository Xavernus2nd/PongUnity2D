using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int _playerScore, _computerScore;
    public Text playerScoreText, computerScoreText;
    public Ball ball;

    public void PlayerScores()
    {
        _playerScore++;
        playerScoreText.text = _playerScore.ToString();
        ball.RestartMatch();
    }
    
    public void ComputerScores()
    {
        _computerScore++;
        computerScoreText.text = _computerScore.ToString();
        ball.RestartMatch();
    }
}
