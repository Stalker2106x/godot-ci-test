using Godot;
using System;

public partial class Test : Control
{
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        var label = GetNode("Label") as Label;
        label.SetText("Hello World!");
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
    }
}