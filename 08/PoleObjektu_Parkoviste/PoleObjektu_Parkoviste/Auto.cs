using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoleObjektu_Parkoviste
{
    internal class Auto
    {
        //Vlastnosti objektu
        public string Znacka;
        public int Kola;
        public string Barva;
        public bool Pokuta;

        //Konstruktor k dané tříde
        //Konstruktor je metoda, která se zavolá při vytvoření nového objektu z dané třídy
        //počet mi zadá uživatel argumentem
        public Auto(int pocet)
        {
            Random gen = new Random();
            //Hodnota vlastnosti Kola je určena parametrem pocet
            Kola = pocet;
            //Hodnota vlastnosti Pokuta je u každého nového objektu automaticky false
            Pokuta = false;

            //Vygenerování náhodných hodnot pro vlastnost Znacka a Barva
            string[] carBrands = new string[]
                {
                    "Toyota", "Honda", "Ford", "Chevrolet", "Nissan", "BMW", "Mercedes-Benz", "Volkswagen", "Audi", "Hyundai",
                    "Kia", "Mazda", "Subaru", "Lexus", "Jaguar", "Porsche", "Ferrari", "Lamborghini", "Maserati", "Bentley",
                    "Rolls-Royce", "Aston Martin", "Bugatti", "McLaren", "Tesla", "Volvo", "Land Rover", "Mini", "Peugeot", "Renault"
                };
            Znacka = carBrands[gen.Next(0, carBrands.Length)];
            string[] colors = new string[]
            {
                "Red", "Green", "Blue", "Yellow", "Purple", "Orange", "Pink", "Brown", "Black", "White",
                "Gray", "Cyan", "Magenta", "Lime", "Maroon", "Navy", "Olive", "Teal", "Silver", "Gold",
                "Beige", "Coral", "Turquoise", "Lavender", "Salmon", "Indigo", "Violet", "Crimson", "Khaki", "Mint",
                "Peach", "Plum", "Tan", "Chocolate", "Ivory", "Azure", "Rose", "Amber", "Emerald", "Sapphire"
            };
            Barva = colors[gen.Next(0, carBrands.Length)];
        }

        //Metoda, kterou umí každý objekt vytvořený z této třídy
        public string Indetifikuj()
        {
            string pomoc = (Pokuta) ? "Má" : "Nemá";
            return $"Značka: {Znacka}, barva: {Barva}, počet kol: {Kola}. {pomoc} pokutu!";
        }
    }
}
