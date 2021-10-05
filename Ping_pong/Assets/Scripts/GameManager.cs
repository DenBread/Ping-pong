using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Ball _ball;
    [SerializeField] private Text _playerScoreText;
    [SerializeField] private Text _computerScoreText;

    [SerializeField] private PlayerPaddle _playerPaddle;
    [SerializeField] private ComputerPaddle _computerPaddle;

    private int _playerScore;
    private int _computerScore;

    public void PlayerScore()
    {
        _playerScore++;

        _playerScoreText.text = _playerScore.ToString();
        ResetRound();
    }

    public void ComputerScore()
    {
        _computerScore++;

        _computerScoreText.text = _computerScore.ToString();
        ResetRound();
    }

    private void ResetRound()
    {
        _playerPaddle.ResetPosition();
        _computerPaddle.ResetPosition();
        _ball.ResetPosition();
        _ball.AddStartingForce();
    }
}
