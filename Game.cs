using System;
using Avalonia.Controls;
using Avalonia.Input;


/// <summary>
/// This is a class
/// </summary>
class Game
{
    private Spaceship _spaceship;
    private Canvas _canvas;

    /// <summary>
    /// Constructor for the game.
    /// </summary>
    /// <param name="canvas">The canvas the game should be shown on</param>
    public Game(Canvas canvas)
    {
        Console.WriteLine("BOssssss!");
        _canvas = canvas;
        _spaceship = new Spaceship(canvas);
    }

    /// <summary>
    /// Updates the game.
    /// </summary>
    public void Update()
    {
        _spaceship.Update();
    }

    /// <summary>
    /// Responds to key presses.
    /// </summary>
    /// <param name="key">The key that was pressed.</param>
    public void HandleKeyPress(Key key)
    {
        switch (key)
        {
            case Key.W:
                _spaceship.SetRotation(0);
                break;
            case Key.D:
                _spaceship.SetRotation(90);
                break;
            case Key.S:
                _spaceship.SetRotation(180);
                break;
            case Key.A:
                _spaceship.SetRotation(270);
                break;
        }
    }
}