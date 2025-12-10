// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using Snake_And_Ladder;

Player player1 = new Player();


String[] options = { "NoPlay", "Ladder", "Snake" };

int roll = Dice.Roll();

switch (options[new Random().Next(options.Length)])
{
    case "Ladder":
        player1.position += roll;
        break;
    case "Snake":
        player1.position -= roll;
        break;
    default:
        break;
}