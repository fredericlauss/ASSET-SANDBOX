using Godot;
using System;

public partial class Main : Node
{
    // Called when the node enters the scene tree for the first time.
    private Node3D niceOne;
    private SpotLight3D lightOne;
    private bool isReversing = false;
    private float currentAngle = 0.0f;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        niceOne = GetNode<Node3D>("map/Node3D/nice_one2");
        lightOne = GetNode<SpotLight3D>("SpotLight3D");
        niceOne.Position = Vector3.Zero;
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
        Animate(delta);
    }

    private void Animate(double delta)
    {
        niceOne.RotateX(Mathf.DegToRad(90.0f * (float)delta));
        niceOne.RotateY(Mathf.DegToRad(90.0f * (float)delta));
        niceOne.RotateZ(Mathf.DegToRad(90.0f * (float)delta));

        float rotationSpeed = 20.0f * (float)delta;
        if (!isReversing)
        {
            currentAngle += rotationSpeed;
            if (currentAngle >= 45.0f)
            {
                currentAngle = 45.0f;
                isReversing = true;
            }
        }
        else
        {
            currentAngle -= rotationSpeed;
            if (currentAngle <= 0.0f)
            {
                currentAngle = 0.0f;
                isReversing = false;
            }
        }
        
        lightOne.RotateX(Mathf.DegToRad(rotationSpeed * (isReversing ? -1 : 1)));
    }
}
