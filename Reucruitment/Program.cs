﻿List<string> möjligaRecruits = [
"Cynthia Mccoy",
"Milford Carroll",
"Cedric Bond",
"Isabelle Guzman",
"Daryl Marquez",
"Cecilia Pollard",
"Jackie Zuniga",
"Gilbert Villarreal",
"Mayra Wolfe",
"Gerry Glenn",
  ];
List<string> nuvarandearbetare = [];

while (nuvarandearbetare.Count < 2)
{

  Console.WriteLine("-- Potential recruits --");
  for (int i = 0; i < möjligaRecruits.Count; i++)
  {
    Console.WriteLine($"{i} {möjligaRecruits [i]}");
  }
  Console.WriteLine("\n-- Current recruits --");
  for (int i = 0; i < nuvarandearbetare.Count; i++)
  {
    Console.WriteLine($"{nuvarandearbetare [i]}");
  }

  Console.WriteLine("\nChoose a recruit:");
  int rNum = 0;
  bool couldConvert = false;
  while (couldConvert == false || rNum < 0 || rNum >= möjligaRecruits.Count)
  {
    string nText = Console.ReadLine();
    couldConvert = int.TryParse(nText, out rNum);

    if (couldConvert == false)
    {
      Console.WriteLine("That's not a number!");
    }
    else if (rNum < 0 || rNum >= möjligaRecruits.Count)
    {
      Console.WriteLine("That's not a valid index!");
    }
  }

  string recruit = möjligaRecruits[rNum];
  nuvarandearbetare.Add(recruit);
  möjligaRecruits.RemoveAt(rNum);
}

Console.WriteLine($"You recruited a total of {nuvarandearbetare.Count} soldiers.");

Console.ReadLine();