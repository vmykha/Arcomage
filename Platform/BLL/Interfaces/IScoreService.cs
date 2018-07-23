﻿using BLL.DTO;
using System.Collections.Generic;

namespace BLL.Interfaces
{
    public interface IScoreService
    {
        //create
        bool AddScore(string userId, int gameId, int value);

        //read
        IEnumerable<ScoreDtoWithEmail> GetScoresByGame(int gameId);
        IEnumerable<ScoreDtoWithEmail> GetTotalAverageScore();
    }
}
