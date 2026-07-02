// See https://aka.ms/new-console-template for more information
Console.WriteLine("This program is gonna read your mind!" +
                  "Type a word");
string? word = Console.ReadLine();
await Task.Delay(4000);
Console.WriteLine(".");
await Task.Delay(2000);
Console.WriteLine("..");
await Task.Delay(2000);
Console.WriteLine("...");
await Task.Delay(2000);
Console.WriteLine("This may take a while!");
await Task.Delay(2000);
Console.WriteLine("....");
await Task.Delay(2000);
Console.WriteLine(".....");
await Task.Delay(2000);
Console.WriteLine("Almost ready!");
await Task.Delay(2000);
Console.WriteLine("......");
await Task.Delay(2000);
Console.WriteLine("Final touches!");
await Task.Delay(2000);
Console.WriteLine("........");
await Task.Delay(2000);

Console.WriteLine("The word you thinked of is:" );
await Task.Delay(3000);
Console.WriteLine( word );

// Thanks for using my silly program in c# !
// made by:         OpenMan335     on Github                     made with:Jetbrains Ride