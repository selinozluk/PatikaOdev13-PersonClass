using OOP_Class;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

string name1 = "Billie";
string surname1 = "Eilish";
int birthdate1 = 2001;


Person person1 = new Person(); // Nesne oluşturuldu

person1.Name = "Billie";
person1.Surname = "Eilish";
person1.Birthdate = new DateTime(2001, 1, 1);


Console.WriteLine($"Kişinin adı: {person1.Name}");
Console.WriteLine($"Kişinin soyadı: {person1.Surname}");
Console.WriteLine($"Kişinin doğum tarihi: {person1.Birthdate}");

// 2. Yol

Person person2 = new Person
{

Name = "Finneas",
Surname = "O'Connel",
Birthdate = new DateTime(1997, 1, 1)

};

Console.WriteLine("---------- 2. Kişi ----------");
Console.WriteLine($"Ad: {person2.Name}");
Console.WriteLine($"Soyad: {person2.Surname}");
Console.WriteLine($"Doğum Tarihi: {person2.Birthdate}");
