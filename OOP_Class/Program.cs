using OOP_Class;
using System;

Person person1 = new Person();
person1.Name = "Billie";
person1.Surname = "Eilish";
person1.Birthdate = new DateTime(2001, 12, 18);

Console.WriteLine($"Kişinin adı: {person1.Name}");
Console.WriteLine($"Kişinin soyadı: {person1.Surname}");
Console.WriteLine($"Kişinin doğum tarihi: {person1.Birthdate.ToString("dd.MM.yyyy")}");

Person person2 = new Person
{
    Name = "Finneas",
    Surname = "O'Connel",
    Birthdate = new DateTime(1997, 7, 30)
};

Console.WriteLine("---------- 2. Kişi ----------");
Console.WriteLine($"Ad: {person2.Name}");
Console.WriteLine($"Soyad: {person2.Surname}");
Console.WriteLine($"Doğum Tarihi: {person2.Birthdate.ToString("dd.MM.yyyy")}");
