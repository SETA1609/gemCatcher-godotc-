using Godot;
using System;


public partial class Dice : Area2D
{
	[Export] private Sprite2D _diceSprite;
	private const float SPEED = 250.0f;
	private const float ROTATION_R = 10.0f;
	private const float ROTATION_L = -10.0f;
	private float _rotationSpeed;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		var rng = new RandomNumberGenerator();
		_rotationSpeed = rng.RandfRange(-10.0f, 10.0f)  > 0.5f ? ROTATION_R : ROTATION_L;
	}

	public override void _PhysicsProcess(double delta)
	{
		Position += new Vector2(0, SPEED * (float)delta);
		_diceSprite.Rotation += _rotationSpeed * (float)delta;
		base._PhysicsProcess(delta);
	}
}
