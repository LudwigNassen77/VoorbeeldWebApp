using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VoorbeeldGitHub.Models
{
    public class Gebruiker
    {
        public string Naam { get; set; }
        public void Start()
        {
            Naam = "Ludwig";
        }
    }
}
