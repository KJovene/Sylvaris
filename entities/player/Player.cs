using Godot;

public partial class Player : CharacterBody2D
{
	// Vitesse de déplacement en pixels/seconde.
	[Export]
	public float Speed = 300.0f;

	public override void _PhysicsProcess(double delta)
	{
		// Récupère la direction à partir des touches fléchées / WASD
		// (actions "ui_*" fournies par défaut par Godot).
		Vector2 direction = Input.GetVector("ui_left", "ui_right", "ui_up", "ui_down");

		Velocity = direction * Speed;

		// Déplace le corps en gérant les collisions automatiquement.
		MoveAndSlide();
	}
}
