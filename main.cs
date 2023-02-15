using System;
using MainProject.GameLoop;

namespace MainProject;

class mainProject
{
    static void Main()
    {
        Game game = new Engine(800,600,"yeet");
        game.Run();
    }
}