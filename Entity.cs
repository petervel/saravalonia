
using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using Avalonia.Platform;

abstract class Entity
{
    public Canvas Canvas { get; private set; }
    public double X;
    public double Y;
    public double Width;
    public double Height;

    public Image Image;

    public bool IsActive = true;

    protected double _rotation;

    public Entity(Canvas canvas, double x, double y, double width, double height, string imageUrl)
    {
        Canvas = canvas;
        X = x;
        Y = y;
        Width = width;
        Height = height;
        Image = new Image
        {
            Source = new Bitmap(AssetLoader.Open(new Uri(imageUrl))),
            Width = Width,
            Height = Height
        };

        canvas.Children.Add(Image);
        Canvas.SetLeft(Image, X);
        Canvas.SetTop(Image, Y);
    }
    
    public Rect GetBounds()
    {
        return new Rect();
    }

    public abstract void Update();

    public void SetInactive()
    {
        IsActive = false;
    }

    public void SetRotation(double rotation)
    {
        _rotation = rotation;
        Image.RenderTransform = new RotateTransform(_rotation);
    }
}