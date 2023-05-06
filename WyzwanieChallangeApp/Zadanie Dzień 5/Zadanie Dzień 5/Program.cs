// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Drawing;

Console.WriteLine("Hello, World!");

//Zadanie dzień 5
// Program , który policzy ile jakich cyfr jest w liczbie 17111956
// pomocne metody;
// int number = 17111956;
// string numberInString = number. ToString();
// char[] letters = numberInString.ToArray();
// <; > ; <=; =>; !=   ( Relacyjne) używane przy if, else
// i logiczne i (&&); lub (||); negacja (!)
// Uwaga jeżeli stosujemy if to piszemy jakiś warunek do spełnienia jeżeli jest spełniony
// to zostaje w lini 
// if (){ Console.WriteLine()}
// jeżeli nie to przechodzi do lini else (){ Console.WriteLine()

//jeżeli if ( np. age czyli wiek określimy na >50) i warunek ten nie został spełniony
// Console.WriteLine(")
//to moprzeszło nam do lini else i tu dopisujemy if( i sprawdzany czy może jest > 40
//jak nie to przechodzi do następnej linii else i else if( moze jest > od 30)i tak cały
// czas sprawdzamy if (>30){Console.WriteLine(>30);if sie spełnił wiek wiekszy niż 30






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






