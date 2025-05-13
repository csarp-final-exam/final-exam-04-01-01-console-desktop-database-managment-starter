﻿using ScholarshipApplicationProject.Console.Models;
using ScholarshipApplicationProject.Console.Repos;

Console.WriteLine("1. feladat");
try
{
    ScholarshipApplicant empty = new ScholarshipApplicant("", "Null");
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine("2. feladat");
ScholarshipApplicant odon = new ScholarshipApplicant("odon@nyertes.hu", "Ösztöndíj Ödön");
Console.WriteLine(odon);

Console.WriteLine("3. feladat");
try
{
    odon.Win(-30000);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine("4. feladat");
odon.Win(20000);
odon.Win(30000);
Console.WriteLine(odon);

Console.WriteLine("5. feladat");
ScholarshipRepo repo = new ScholarshipRepo();
Console.WriteLine($"Öszdöndijasok száma: {repo.GetNumberOfScholarship()}");