using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VizeÖdevi.Models
{
    public class KamyoncuVeri
    {
        public static List<Kamyoncu> Kamyoncular = new List<Kamyoncu>()
        {
            new Kamyoncu()
            {
                Id = 1,
                Ad = "Furkan",
                Soyad = "Ersin",
                Tckimlik = "123"
            },

              new Kamyoncu()
            {
                Id = 2,
                Ad = "Ersin",
                Soyad = "Furkam",
                Tckimlik = "321"
            },



                new Kamyoncu()
            {
                Id = 3,
                Ad = "Furkan",
                Soyad = "Ersin",
                Tckimlik = "321"
            },



        };

    }
}
