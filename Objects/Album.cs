using System.Collections.Generic;

namespace Organizer.Objects
{
    
    public class Album
    {
        private string _title;
        private int _id;
        private Artist _artist;
        private static List<Album> _instances = new List<Album> { };

        public Album(string title, string artistName)
        {
            _title = title;
            _artist = new Artist(artistName);
            _instances.Add(this);
            _id = _instances.Count;
        }

        public string GetTitle()
        {
            return _title;
        }

        public void SetTitle(string NewTitle)
        {
            _title = NewTitle;
        }

        public string GetArtistName()
        {
            return _artist.GetName();
        }

        public int GetId()
        {
            return _id;
        }

        public static List<Album> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }
    }

    public class Methods
    {
        public static List<Album> FindMatching(List<Album> allAlbums, string ArtistName)
        {
            
            List<Album> Matching = new List<Album> { };
            string lowerArtistName = ArtistName.ToLower();

            for (int i = 0; i < allAlbums.Count; i++)
            {
                string name = allAlbums[i].GetArtistName();
                name = name.ToLower(); 
                if (lowerArtistName.Contains(" "))
                {
                    string[] ArtistNameWords = lowerArtistName.Split(' ');
                    foreach (string word in ArtistNameWords)
                    {
                        if (name.Contains(word) || word.Contains(name))
                        {
                            if (Matching.Contains(allAlbums[i]))
                            {
                                continue;
                            }
                            else
                            {
                                Matching.Add(allAlbums[i]);
                            }
                            
                        }
                    }
                }
                else if (name.Contains(lowerArtistName) || lowerArtistName.Contains(name))
                {
                    if (Matching.Contains(allAlbums[i]))
                    {
                        continue;
                    }
                    else
                    {
                        Matching.Add(allAlbums[i]);
                    }
                }
            }
            return Matching;
        }
    }
}