// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using Snake_And_Ladder;



String[] options = { "NoPlay", "Ladder", "Snake" };

Console.WriteLine("Welcome to Snake and Ladder Game!");

string name1 = null;
while (String.IsNullOrEmpty(name1))
{
    Console.Write("\n\nEnter the name of the fisrt player: ");
    name1 = Console.ReadLine();
}

string name2 = null;
while (String.IsNullOrEmpty(name2))
{
    Console.Write("\n\nEnter the name of the second player: ");
    name2 = Console.ReadLine();
}

Player player1 = new Player(name1);
Player player2 = new Player(name2);

Console.WriteLine("Press any key to start the game...");
Console.ReadKey();

int count = 0;

Random random = new Random();

Player player = player1;

while (player1.position < 100 && player2.position < 100)
{
    if(player1.position < 0) player1.position = 0;
    if(player2.position < 0) player2.position = 0;
    
    int roll = Dice.Roll();
    count++;
    
    string option = options[random.Next(options.Length)];
    Console.WriteLine($"Roll: #{count}, Player: {player.Name}, position: {player.position}, roll: {roll}, option: {option}");

    
    switch (option)
    {
        case "NoPlay":
            player = (player == player1) ? player2 : player1;
            break;
        case "Ladder":
            if (player.position + roll > 100) continue; 
            player.position += roll;
            break;
        case "Snake":
            player.position -= roll;
            player = (player == player1) ? player2 : player1;
            break;
    }
}

Console.WriteLine((player1.position == 100) ? $"{player1.Name} Won!" : $"{player2.Name} Won!"); 