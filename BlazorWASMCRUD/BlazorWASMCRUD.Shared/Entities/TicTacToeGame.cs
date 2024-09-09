﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWASMCRUD.Shared.Entities
{
    public class TicTacToeGame
    {
        public string? PlayerXId { get; set; }
        public string? PlayerOId { get; set; }
        public string? CurrentPlayerId { get; set; }
        public string CurrentPlayerSymbol => CurrentPlayerId == PlayerXId ? "X" : "O";
        public bool GameStarted { get; set; } = false;
        public bool GameOver { get; set; } = false;
        public bool IsDraw { get; set; } = false;
        public string Winner {  get; set; } = string.Empty;
        public List<List<string>> Board {  get; set; } = new List<List<string>>(3);

        public TicTacToeGame() 
        {
            InitializeBoard();
        }

        public void StartGame()
        {
            CurrentPlayerId = PlayerXId;
            GameStarted = true;
            GameOver = false;
            Winner = string.Empty;
            IsDraw = false;
            InitializeBoard();
        }

        private void InitializeBoard()
        {
            Board.Clear();
            for (int i = 0; i < 3; i++)
            {
                var row = new List<string>(3);
                for (int j = 0; j < 3; j++)
                {
                    row.Add(string.Empty);
                }
                Board.Add(row);
            }
        }

        public void TogglePlayer()
        {
            CurrentPlayerId = CurrentPlayerId == PlayerXId ? PlayerOId : PlayerXId;
        }

        public bool MakeMove(int row, int col, string playerId)
        {
            if(playerId != CurrentPlayerId || row < 0 || row >= 3 || col < 0 || col >= 3 || Board[row][col] != string.Empty)
            {
                return false;
            }
            Board[row][col] = CurrentPlayerSymbol;
            TogglePlayer();
            return true;
        }

        public string CheckWinner()
        {
            for(int i = 0; i < 3; i++)
            {
                if (!string.IsNullOrEmpty(Board[i][0]) && Board[i][0] == Board[0][1] && Board[i][1] == Board[0][2])
                {
                    return Board[i][0];
                }
            }

            if (!string.IsNullOrEmpty(Board[0][0]) && Board[0][0] == Board[1][1] && Board[1][1] == Board[2][2])
            {
                return Board[0][0];
            }

            if (!string.IsNullOrEmpty(Board[0][2]) && Board[0][2] == Board[1][1] && Board[1][1] == Board[2][0])
            {
                return Board[0][2];
            }
            return string.Empty;
        }

        public bool CheckDraw()
        {
            return IsDraw = Board.All(row => row.All(cell => !string.IsNullOrEmpty(cell)));
        }
    }
}
