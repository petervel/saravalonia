using System;
using Avalonia.Controls;

class Spaceship : Entity
{
    const int WIDTH = 100;
    const int HEIGHT = 100;

    public Spaceship(Canvas canvas): base(canvas, canvas.Width / 2, canvas.Height / 2, WIDTH, HEIGHT, "avares://Saravalonia/Assets/spaceship.png")
    {
    }

    public override void Update()
    {
        
        Console.WriteLine("WREUH?");
        
    }
}
