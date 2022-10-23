using Windows.Devices.Radios;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


foreach (var radio in await Radio.GetRadiosAsync())
{
    Console.WriteLine($"Name:{radio.Name}, Kind:{radio.Kind}, State:{radio.State}");
}

Console.ReadLine();