using System;
using System.Collections.Generic;
using System.Linq;

Main();

void Main()
{
    Console.WriteLine("Welcome to the Magic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();
    MooseSays("H I, I'M  M A G I C !");
    MooseSays("I really am magic");
    MooseAsks("Ask me any yes/no question.");
}
void MooseAsks(string question)
{
    Console.Write($"{question} : ");
    string answer = Console.ReadLine().ToLower();
    Random r = new Random();
    int genRand = r.Next(0, 19);
    List<string> answers = new List<string>()
    {
        "As I see it, yes.",
        "Ask again later.",
        "Better not tell you now.",
        "Cannot predict now.",
        "Concentrate and ask again.",
        "Dont count on it.",
        "It is certain.",
        "It is decidedly so.",
        "Most likely.",
        "My reply is no.",
        "My sources say no.",
        "Outlook not so good.",
        "Outlook good.",
        "Reply hazy, try again.",
        "Signs point to yes.",
        "Very doubtful.",
        "Without a doubt.",
        "Yes.",
        "Yes, definitely.",
        "You may rely on it.",
    };
    if (answer != "" )
    {
        MooseSays(answers[genRand]);
        MooseAsks("Ask my any yes/no question.");
    }
    else
    {
        Environment.Exit(-1);
    }
}

void MooseSays(string message)
{
    Console.WriteLine($@"
                                      _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}


