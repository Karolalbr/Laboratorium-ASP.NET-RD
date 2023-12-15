using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace labaspnet.Models
{
    public class Album
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "Proszę podać nazwę Albumu!")]
        public string AlbumName { get; set; }

        [Required(ErrorMessage = "Proszę podać nazwę zespołu!")]
        public string BandName { get; set; }

        [Range(1, 10000, ErrorMessage = "Proszę podać liczbę piosenek.")]
        public int SongList { get; set; }

        [Required(ErrorMessage = "Proszę podać notowanie!")]
        public string Rating { get; set; }

        [Range(1950, 2023, ErrorMessage = "Rok wydania musi być w zakresie od 1950 do 2023.")]
        public int DatePublished { get; set; }

        [Required(ErrorMessage = "Proszę podać czas trwania!")]
        public string Duration { get; set; }
    }
}
