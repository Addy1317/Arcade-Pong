using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SlowpokeStudio.ArcadePong
{
    public class GameManager : MonoBehaviour
    {
        private int _playerScore;
        private int _computerScore;
        [SerializeField] private Ball _ball;
        public void PlayerScore()
        {
            _playerScore++;
            Debug.Log("PlayerScore : " + _playerScore);
            this._ball.ResetPosition();
        }

        public void ComputerScore() 
        {
            _computerScore++;
            Debug.Log("ComputerScore : " + _computerScore);
            this._ball.ResetPosition();
        }
    }
}
