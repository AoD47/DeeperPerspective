using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeeperPerspective.Models
{
    public class ArtPiece
    {
        public string ID { get; set; }
        public string FilePath { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public DateTime DateCreated { get; set; }
        public double Price { get; set; }
        public bool InStock { get; set; }
        public bool CurrentOwner { get; set; }
    }
}
