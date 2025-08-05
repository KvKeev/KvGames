using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvGames.Models
{
    public class UserGameData
    {
        public int GameId { get; set; } = 0;
        public bool isCompleted { get; set; } = false;
        public int RatingGiven { get; set; } = 0;

    }
}
