using Nancy;
using Organizer.Objects;
using System.Collections.Generic;

namespace AlbumOrganizer
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ =>
            {
                var allAlbums = Album.GetAll();
                return View["index.cshtml", allAlbums];
            };
            Get["/album/new"] = _ =>
            {
                return View["album_form.cshtml"];
            };
            Post["/albums"] = _ =>
            {
                var newAlbum = new Album(Request.Form["album-title"], Request.Form["artist-name"]);
                var allAlbums = Album.GetAll();
                return View["index.cshtml", allAlbums];
            };
            Get["/searchbyartist"] = _ =>
            {
                return View["search_form.cshtml"];
            };
            Post["/artists"] = _ =>
            {
                var artistName = Request.Form["artist-name"];
                var allAlbums = Album.GetAll();

                var matchingAlbums = Methods.FindMatching(allAlbums, artistName);
                return View["albums_by_artist.cshtml", matchingAlbums];
            };
                  
        }
    }
}