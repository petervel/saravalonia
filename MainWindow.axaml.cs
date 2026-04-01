using System;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Threading;

namespace Saravalonia;

public partial class MainWindow : Window
{
    private DispatcherTimer _timer;
    private Game _game;

    public MainWindow()
    {
        InitializeComponent();

        _game = new Game(DrawCanvas);

        _timer = new DispatcherTimer() { Interval = TimeSpan.FromMilliseconds(1000 / 30) };
        _timer.Tick += OnTick!;
        _timer.Start();
    }

    void OnTick(object sender, EventArgs e)
    {
        _game.Update();
    }

    /// <summary>
    /// Responds to key presses.
    /// </summary>
    /// <param name="e">The key event</param>
    protected override void OnKeyDown(KeyEventArgs e)
    {
        _game.HandleKeyPress(e.Key);
    }
}