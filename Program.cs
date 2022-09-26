// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Net.Sockets;

Console.WriteLine("Hello, guyss!");

string[] name =
{
    "Дилюк", "Нахида", "Сайно"
};
Random rnd = new Random();
int index = rnd.Next(name.Length);

    string[] fam =
    {
        "Каэдехара", "Камисато", "Аратаки"
    };
    Random rnd1 = new Random();
    int index1 = rnd1.Next(fam.Length);

string[] otch =
{
    "Дилюкович", "Кейевич", "Казухович"
};
Random rnd2 = new Random();
int index2 = rnd2.Next(otch.Length);
Console.WriteLine("ФИО: " + " " + fam[index1] + " " + name[index] + " " + otch[index2]);

int[] age =
{
    19, 34, 43
};
Random rnd3 = new Random();
int index3 = rnd3.Next(age.Length);
Console.WriteLine("возраст: " + age[index3]);

string[] city =
{
    "Сумеру", "Ли Юэ", "Фонтейн"
};
Random random = new Random();
int index4 = random.Next(city.Length);
Console.WriteLine("место рождения: " + city[index4]);


