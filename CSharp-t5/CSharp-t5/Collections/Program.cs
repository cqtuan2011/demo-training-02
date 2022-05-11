Console.WriteLine("Input number from 0 - 4 for the lucky present: ");
int number = int.Parse(Console.ReadLine());

string[] present = { "Candy", "Teddy bear", "Shirt", "100$ dolars", "Water bottle" };

Console.WriteLine($"Congratulation! You have won the present of {present[number]}");


