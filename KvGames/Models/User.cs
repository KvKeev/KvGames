using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvGames.Models
{
    public class User
    {

        public int Id { get; set; } = 0;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime RegistrationDate { get; set; } = DateTime.Now;
        public bool IsAdmin { get; set; } = false;

        public List <UserGameData> UserGameData { get; set; } = new List<UserGameData>();

        public User() { }

        public User(int id, string username, string password, string email, bool isAdmin = false)
        {
            Id = id;
            Username = username;
            Password = password;
            Email = email;
        }

        public bool HasDownloadedGame(int gameId)
        {
            return UserGameData.Any(ugd => ugd.GameId == gameId);
        }



    }
}
