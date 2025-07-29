using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvGames.Models
{
    public class Game
    {
        public int Id { get; set; } = 0;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public int DownloadCount { get; private set; } = 0;
        public double AverageRating { get; private set; } = 0.0;
        public int TotalRating { get; private set; } = 0;
        public int RatingSum { get; private set; } = 0;
        public DateTime ReleaseDate { get; set; } = DateTime.Now;


        public Game(int id, string title, string description, string genre)
        {
            Id = id;
            Title = title;
            Description = description;
            Genre = genre;
        }

        public void AddRating(int rating)
        {
            if (rating < 1 || rating > 5)
            {
                throw new ArgumentOutOfRangeException(nameof(rating), "Rating must be between 1 and 5.");
            }
            TotalRating++;
            RatingSum += rating;
            CalculateAverageRating();
        }

        public void CalculateAverageRating()
        {
            if (TotalRating > 0)
            {
                AverageRating = (double)RatingSum / TotalRating;
            }
            else
            {
                AverageRating = 0.0;
            }
        }

        public override string ToString()
        {
            return $"Id: {Id}, Title: {Title}, Description: {Description}, Genre: {Genre}, " +
                   $"DownloadCount: {DownloadCount}, AverageRating: {AverageRating:F2}, " +
                   $"TotalRating: {TotalRating}, RatingSum: {RatingSum}, ReleaseDate: {ReleaseDate.ToShortDateString()}";
        }

        public void IncrementDownloadCount()
        {
            DownloadCount++;
        }


    }
}
