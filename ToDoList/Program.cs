using System;
using System.Collections.Generic;
using ToDoList.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace ToDoList
{
  public class Program
  {
    
    public static void Main(string[] args)
    {
      var host = new WebHostBuilder()
      .UseKestrel()
      .UseContentRoot(Directory.GetCurrentDirectory())
      .UseIISIntegration()
      .UseStartup<Startup>()
      .Build();

      host.Run();
  
      // Greeting();
      // static void Greeting()
      // {
      //   Console.WriteLine("Welcome to the To-Do List");
      //   AddOrViewList();
      // }
      // static void AddOrViewList()
      // {
      //   Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View)");
      //   string answer = Console.ReadLine();

      //   if (answer == "Add" || answer == "add")
      //   {
      //     Console.WriteLine("Please enter the description for the new item");
      //     string response = Console.ReadLine();
      //     Item newItem = new Item(response);
      //     Console.WriteLine(response + " has been added to your list");
      //     AddOrViewList();
      //   }
      //   else
      //   {
      //     List<Item> completeList = new List<Item>() { };
      //     completeList = Item.GetAll();
      //     if (completeList.Count == 0) {
      //       Console.WriteLine("Your list is empty, add a task first.");
      //       AddOrViewList();
      //     } else
      //     {
      //       foreach (var element in completeList)
      //       {
      //         Console.WriteLine("An item on your to do list is " + element.Description);
      //       }
      //       AddOrViewList();
      //     }
        // }
      // }
    }
  }
}
