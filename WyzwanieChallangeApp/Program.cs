// See https://aka.ms/new-console-template for more information
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

https://github.com/grzemik56/WyzwanieChallangeApp

//                                  Zadanie dzień 5
// Przygotuj program, który policzy ile jakich cyfr jest w podanej liczbie
//
// Przykład 
// Wynik dla liczby 4566
// 0 => 0
// 1 => 0
// 2 => 0
// 3 => 0
// 4 => 1
// 5 => 1
// 6 => 2 
// 7 => 0
// 8 => 0
// 9 => 0


//int number = 4566;
//string numberInString = number.ToString();
//char[] letters = numberInString.ToArray();

//int number = 171119;




        int number = 171119;
string numberInString = number.ToString();
char[] letters = numberInString.ToCharArray();
Console.WriteLine(letters);
int digit0 = 0;
int digit1 = 0;
int digit2 = 0;
int digit3 = 0;
int digit4 = 0;
int digit5 = 0;
int digit6 = 0;
int digit7 = 0;
int digit8 = 0;
int digit9 = 0;

foreach (char letter in letters)
{
    if (letter == '0')
    {
        digit0++;
    }
    else if (letter == '1')
    {
        digit1++;
    }
    else if (letter == '2')
    {
        digit2++;
    }
    else if (letter == '3')
    {
        digit3++;
    }
    else if (letter == '4')
    {
        digit4++;
    }
    else if (letter == '5')
    {
        digit5++;
    }
    else if (letter == '6')
    {
        digit6++;
    }
    else if (letter == '7')
    {
        digit7++;
    }
    else if (letter == '8')
    {
        digit8++;
    }
    else if (letter == '9')
    {
        digit9++;

        Console.WriteLine("jest cyfra 0 w liczbie 0 " + digit0);
        Console.WriteLine("jest cyfra 0 w liczbie 1 " + digit1);
        Console.WriteLine("jest cyfra 0 w liczbie 2 " + digit2);
        Console.WriteLine("jest cyfra 0 w liczbie 3 " + digit3);
        Console.WriteLine("jest cyfra 0 w liczbie 4 " + digit4);
        Console.WriteLine("jest cyfra 0 w liczbie 5 " + digit5);
        Console.WriteLine("jest cyfra 0 w liczbie 6 " + digit6);
        Console.WriteLine("jest cyfra 0 w liczbie 7 " + digit7);
        Console.WriteLine("jest cyfra 0 w liczbie 8 " + digit8);
        Console.WriteLine("jest cyfra 0 w liczbie 9 " + digit9);


    }

}


int number = 171119;
string numberInString = number.ToString();
char[] letters = numberInString.ToCharArray();

Console.WriteLine(letters);
int digit0 = 0;
int digit1 = 0;
int digit2 = 0;
int digit3 = 0;
int digit4 = 0;
int digit5 = 0;
int digit6 = 0;
int digit7 = 0;
int digit8 = 0;
int digit9 = 0;


