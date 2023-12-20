using labaspnet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using System.Linq;

namespace labaspnet.Controllers
{
    [Authorize]
    public class AlbumController : Controller
    {
        private static List<Album> _albums = new List<Album>();

        [AllowAnonymous]
        public IActionResult Index()
        {
            var albumsDictionary = _albums.ToDictionary(album => album.Id);
            return View(albumsDictionary);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Album album)
        {
            if (ModelState.IsValid)
            {
                album.Id = _albums.Any() ? _albums.Max(a => a.Id) + 1 : 1;
                _albums.Add(album);
                return RedirectToAction("Index");
            }
            return View(album);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var album = _albums.FirstOrDefault(a => a.Id == id);
            if (album == null)
            {
                return NotFound();
            }
            return View(album);
        }

        [HttpPost]
        public IActionResult Edit(Album album)
        {
            if (ModelState.IsValid)
            {
                var existingAlbum = _albums.FirstOrDefault(a => a.Id == album.Id);
                if (existingAlbum == null)
                {
                    return NotFound();
                }

                existingAlbum.AlbumName = album.AlbumName;
                existingAlbum.BandName = album.BandName;

                return RedirectToAction("Index");
            }
            return View(album);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var album = _albums.FirstOrDefault(a => a.Id == id);
            if (album == null)
            {
                return NotFound();
            }
            return View(album);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var album = _albums.FirstOrDefault(a => a.Id == id);
            if (album != null)
            {
                _albums.Remove(album);
                return RedirectToAction("Index");
            }
            return NotFound();
        }

        [AllowAnonymous]
        public IActionResult Details(int id)
        {
            var album = _albums.FirstOrDefault(a => a.Id == id);
            if (album == null)
            {
                return NotFound();
            }
            return View(album);
        }
    }
}
