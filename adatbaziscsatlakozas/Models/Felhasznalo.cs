using System.ComponentModel.DataAnnotations;

namespace adatbaziscsatlakozas.Models
{
    public class Felhasznalo
    {
        public int Id { get; set; }

        public string Nev { get; set; }

        public int SzulDatum { get; set; }

        public string Email { get; set; }
    }
}
