﻿using ConsoleApp;
using Entities.Models;
using System.Collections;

public class Practice
{
    public void ArrayDefination()
    {
        var BookArr =
        new Book[] {
        new Book(){Id = 2, Title = "Yoldaki İşaretler"},
        new Book { Id=3, Title = "C# Hakkında Herşey"}
        };

        for (int i = 0; i < BookArr.Length; i++)
        {
            Console.WriteLine(BookArr[i]);
        }

        BookArr[1].Id = 30;
        BookArr[1].Title = "Mars";

        Console.WriteLine();
        foreach (var book in BookArr)
        {
            Console.WriteLine(book);
        }

        // mutable (değişebilir) -  immutable (değişemez)

        var newBookArr = new Book[5];

        for (int i = 0; i < BookArr.Length; i++)
        {
            newBookArr[i] = BookArr[i];
        }
      

        foreach (var item in newBookArr)
        {
            Console.WriteLine(item);
        }

        Console.ReadKey();
    }

    public void UseMathInProgram()
    {
        var math = new ConsoleApp.Math.Math();

        var c = math.Sum(3, 5);
        Console.WriteLine(typeof(ConsoleApp.Math.Math).FullName);
        Console.WriteLine(c.GetType());
        Console.WriteLine(c);


        var d = math.Multipy(c, 2); // 16 
        Console.WriteLine($"{c}*2 = {d}");

        var e = math.Subtraction(d + 10, c); // 16+10 - 8 = 18
        Console.WriteLine($"{d + 10}-{c} = {e}");
    }

    public void UseParamsKeyword()
    {
        var math = new ConsoleApp.Math.Math();
        Console.WriteLine(math.Sum(1, 3));                      // 4
        Console.WriteLine(math.Sum(10));                        // 10
        Console.WriteLine(math.Sum(1, 3, 4, 5));                // 13
        Console.WriteLine(math.Sum(1, 3, 4, 5, 10, 30));        // 53
    }

    public void UseArrayList()
    {
        var bookList = new ArrayList();

      
        bookList.Add("Ömer");
        bookList.Add(true);
        bookList.Add(DateTime.Now);
        bookList.Add(25);
        bookList.Add(5 / 2);

        bookList.AddRange(new int[] { 1, 2, 3 });

        Console.WriteLine(String.Format("Number of item in collection : {0}", bookList.Count));

        foreach (var item in bookList)
        {
            Console.WriteLine(item);
        }

        bookList.Remove(true);
        bookList.RemoveAt(0);
        bookList.RemoveRange(0, 3);
        Console.WriteLine(String.Format("Number of item in collection : {0}", bookList.Count));

        foreach (var item in bookList)
        {
            Console.WriteLine(item);
        }
    }

    public void UseListBook()
    {
        var bookList = new List<Book>()
{
   
};

        bookList.ForEach(book => Console.WriteLine(book));

        Console.WriteLine();
        foreach (var item in bookList)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();

        int index = 0;
        while (index < bookList.Count)
        {
            Console.WriteLine(bookList[index]);
            index++;
        }
    }
}