using Godot;
using System;


public partial class Dice : Area2D
{
	[Export] private Sprite2D _diceSprite;
	private const  float SPEED = 250.0f;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	public override void _PhysicsProcess(double delta)
	{
		float rotation = new RandomNumberGenerator().RandfRange(-10, 10);
		Position += new Vector2(0, SPEED * (float)delta);
		_diceSprite.Rotation += rotation * (float)delta;
		base._PhysicsProcess(delta);
	}
}
