using Godot;
using System;

public partial class Main : Node
{
    private Node3D niceOne;
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
	{
        niceOne = GetNode<Node3D>("map/Node3D");
    }

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
        Animate(delta);
    }

    private void Animate(double delta)
    {
        niceOne.RotationDegrees += new Vector3(45.0f, 45.0f, 45.0f) * (float)delta;
    }
}
