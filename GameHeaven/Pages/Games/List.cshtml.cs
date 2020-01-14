using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameHeaven.Core;
using GameHeaven.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GameHeaven
{
    public class ListModel : PageModel
    {
        private readonly IGameData gameData;

        public IEnumerable<Game> Games { get; set; }

        public ListModel(IGameData gameData)
        {
            this.gameData = gameData;
        }
        public void OnGet()
        {
            Games = gameData.GetAll();
        }
    }
}