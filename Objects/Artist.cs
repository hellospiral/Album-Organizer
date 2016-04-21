using System.Collections.Generic;

namespace Organizer.Objects
{
    public class Artist
    {
        private string _name;

        public Artist(string name)
        {
            _name = name;
        }
        public string GetName()
        {
            return _name;
        }
        public void SetName(string NewName)
        {
            _name = NewName;
        }
    }
}