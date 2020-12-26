using Godot;
using System;

public class Node2D : Godot.Node2D
{
    private Sprite sprite0;
    
    [Export]
    private float speed;

    public override void _Ready()
    {
        sprite0 = GetNode<Sprite>("sprite0");
    }


    public override void _Process(float delta)
    {
        var move = Vector2.Zero;
        if (Input.IsActionPressed("left"))
            move.x -= speed;
        if (Input.IsActionPressed("right"))
            move.x += speed;
        if (Input.IsActionPressed("up"))
            move.y -= speed;
        if (Input.IsActionPressed("down"))
            move.y += speed;

        sprite0.Position += move * delta;
    }
}
