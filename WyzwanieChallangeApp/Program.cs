﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//  ZMIENNE

    
        var myAge = 33;
        int myAge2 = 33;
        int myAge3 = int.MaxValue;
        int myAge4 = int.MinValue;
        int myAge5 = 120;
        int newAge = myAge5 + 5;
        Console.WriteLine(newAge);

        int myVar = int.MaxValue;
        int myVar2 = int.MinValue;
        Console.WriteLine(myVar);
        Console.WriteLine(myVar2);

        // Liczby całkowite wieksze od int ale od zera w góre
        uint myVar3 = uint.MaxValue;
        uint myVar4 = uint.MinValue;
        long myVar5 = long.MaxValue;
        ulong myVar6 = ulong.MaxValue;

        // Liczby zmiennoprzecinkowe
        double myNamber1 = double.MaxValue;
        decimal myNamber2 = decimal.MaxValue;

        // Zmienne Tekstowe

        string name = "Grzegorz";
        string surname = "Mikłasz";
        string result = name + surname;
        Console.WriteLine(result);
        string result1 = name + surname + "int newAge";
        Console.WriteLine(result1);
        // Jeżeli do stringa dodamy int to z inta zrobi się string czyli z liczby tekst

        // Zmienna tekstowa char, ktora przechowuje tylko jedną litere, symbol,znak'c' 'a'

        char myVar1 = 'c';

        //  każdy string może być podzielony na char
        var result2 = name.ToArray();

        // Zmienne logiczne
        bool isActive = false;
        isActive = true;
        bool result3 = true;
        bool result4 = false;

        var isValid = 5 > 6;
        Console.WriteLine(isValid);
        //po kompilacji pokazało, że fals czyli 5 nie jest większa od 6

        // Instrukcja If i podstawy debugowania

        var number1 = 5;
        var number2 = 10;

        if (number1 < number2)
        {

            Console.WriteLine("jestem w 65");


        }
        else
        {
            Console.WriteLine("jestem w 71");
        }
        var number3 = 50;
        var number4 = 10;
        if (number3 > number4)
        {
            Console.WriteLine("jestem w 77");
        }

        // Operatory relacyjne i logiczne;
        // jeżeli różne !=
        //mniejsze <
        //wieksze >
        //równe == równe piszemy 
        //różne!=
        // mniejsze równe <=
        // większe równe >=
       
        var nameAdam = "Adam";
        var ageAdam = 33;
        
// Operator i to znak "&&" znak lub to "II"

        if (nameAdam == "Adam" && ageAdam < 50)
        {
            Console.WriteLine("Jestem Adamem przed 50");
        }
        else
        {
            Console.WriteLine("Jestem Adamem kimś innym");
        }
        if (nameAdam == "Adam" || ageAdam < 50)
        {
            Console.WriteLine("Jestem Adamem 50");

        }

        // $$ oznacza i
        // || oznacza lub
        // !  oznacz negację

        bool isActive1 = true;

        if (!isActive1)
        {
            Console.WriteLine("jestem Adamem lub mam mniej niz 50");
        }
        if (ageAdam > 50)
        {
            Console.WriteLine("JestemAdamem i mam mniej");
        }
        else if (ageAdam > 40)
        {
            Console.WriteLine("40-50 latek");
        }
        else if (ageAdam > 30)
        {
            Console.WriteLine("40-50latek");

}



internal partial class Program
{
    public static bool Mężczyzna { get; private set; }

    private static void Main(string[] args)
    {
        string name = "Adam";
        string surname = "Kamizelich";
        string result = name + surname;
        var ageAdam = "33";

        Console.WriteLine(result);
        string result1 = name + surname + ageAdam;
        Console.WriteLine("Adam Kamizelich 56");
        Console.WriteLine(result1);

        //Zamiast nazwiska wstawiamy 1
        string nameA = "Adam";
        string surname1 = "1";
        string result2 = nameA + surname1 + ageAdam;
        Console.WriteLine(result2);

        //Zmienna char

        char myVar = 'c';

        //można podzielić( Split) zmienną string np.( name) na char czyli 

        // var result3 = name3.Split;
        // var result4 = name4.ToArray();
        //Console.WriteLine(result3); 


        //Do podziału służą Split lub ToArray

        //ZmiennaLogiczna 
        //bool isActive = false;
        //bool isActive = true;

        bool isActive = true;
        isActive = false;
        var isValid = 5 > 6;
        Console.WriteLine(isValid);

        //Zadanie dzień 4
        var ageKobieta = 29;
        string nameEwa = "Ewa";
        string Gender = "Kobieta, lat";
        var ageEwa = 33;
        string result5 = nameEwa + Gender + ageEwa;
        Console.WriteLine(result5);
        if (Gender == "Kobieta, lat")
        {
            if (ageKobieta == 29 && ageKobieta <= 30)
            {
                Console.WriteLine("Kobieta, mniej niż 30lat ");
            }

            {
                var nameAdult = "Pełnoletni";
                var nameMinor = "Niepełnoletni";
                var gender = "Mężczyzna";
                var ageAdult = 18;
                var ageMinor = "<18";
                isActive = true;

                if (Gender == "Mężczyzna" & ageAdult == 18)
                    if (gender == "Mężczyzna" && nameAdult == "Pełnoletni")
                    {

                    }
                {
                    Console.WriteLine("Mężczyzna Pełnoletni");
                }

                if (ageMinor == "<18" && gender ==  "Mężczyzna")
                {
                    Console.WriteLine("Mężczyzna Niepełnoletni");

                }
            }



            bool genderMarcin = Mężczyzna;
            isActive = true;

            if (genderMarcin == Mężczyzna)
            {
                Console.WriteLine("");
            }

            {
                Console.WriteLine("Marcin Mężczyzna");

            }
            {


                {
                    Console.WriteLine("Marcin");
                }

                {
                    Console.WriteLine(value: "Marcin, nie jest Mężczyzna");
                    if (isActive = true)
                    {

                    }
                }
            }
        }
    }
}



