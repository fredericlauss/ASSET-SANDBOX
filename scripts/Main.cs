using Godot;
using System;

public partial class Main : Node
{
    private Node3D niceOne;
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
	{
        niceOne = GetNode<Node3D>("map/nice_one");
    }

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
        Animate(delta);
    }

    private void Animate(double delta)
    {
        niceOne.RotateY((float)delta * 1.5f);
        niceOne.RotateX((float)delta * 0.5f);
    }
}
