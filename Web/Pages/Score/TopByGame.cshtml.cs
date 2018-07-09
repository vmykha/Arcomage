using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.DTO;
using BLL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Pages.Score
{
    [Authorize]
    public class TopByGameModel : PageModel
    {
        private readonly IScoreService _scoreService;

        [BindProperty]
        public List<ScoreDtoWithEmail> Scores { get; set; }

        public TopByGameModel(IScoreService scoreService)
        {
            _scoreService = scoreService;
        }

        public void OnGet(int id)
        {
            Scores = _scoreService.GetScoresByGame(id).ToList();
        }
    }
}