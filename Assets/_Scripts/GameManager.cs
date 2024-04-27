using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Net.NetworkInformation;

namespace SlowpokeStudio.ArcadePong
{
    public class GameManager : MonoBehaviour
    {
        [Header("Paddle Reference")]
        [SerializeField] private PlayerPaddle _playerPaddle;
        [SerializeField] private ComputerPaddle _computerPaddle;

        [Header("Ball Reference")]
        [SerializeField] private Ball _ball;

        [Header("UI Reference")]
        [SerializeField] private TMP_Text _playerScoreText;
        [SerializeField] private TMP_Text _computerScoreText;

        private int _playerScore;
        private int _computerScore;

        public void PlayerScore()
        {
            _playerScore++;
            this._playerScoreText.text = _playerScore.ToString();
            ResetRound();
        }

        public void ComputerScore()
        {
            _computerScore++;
            this._computerScoreText.text = _computerScore.ToString();
            ResetRound();
        }

        private void ResetRound()
        {
            this._playerPaddle.ResetPosition();
            this._computerPaddle.ResetPosition();
            this._ball.ResetPosition();
            this._ball.AddStartForce();
        }


    }
}
