using MainProject.Display;
using GLFW;
using System;
using System.Collections.Generic;
using System.Text;

namespace MainProject.GameLoop;

abstract class Game
{
    protected int InitialWindowWidth {get;set;}
    protected int InitialWindowHeight {get;set;}
    protected string InitialWindowTitle {get;set;}

    public Game(int initialWindowWidth, int initialWindowHeight, string initialWindowTitle)
    {
        this.InitialWindowHeight = initialWindowHeight;
        this.InitialWindowWidth = initialWindowWidth;
        this.InitialWindowTitle = initialWindowTitle;
    }

    public void Run()
    {
        Initialize();

        _Display.CreateWindow(InitialWindowWidth, InitialWindowHeight, InitialWindowTitle);

        LoadContent();

        while(!Glfw.WindowShouldClose(_Display.Window))
        {
            GameTime.DeltaTime = (float)Glfw.Time - GameTime.TotalElapsedSeconds;
            GameTime.TotalElapsedSeconds = (float)Glfw.Time;

            Update();

            Glfw.PollEvents();

            Render();
        }
    }

    protected abstract void Initialize();
    protected abstract void LoadContent();

    protected abstract void Update();
    protected abstract void Render();
}
