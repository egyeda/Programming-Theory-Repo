using UnityEngine;

//INHERITANCE
public class Tank : Vehicle
{
	private float stutterTimer = 0;
	void Start()
	{
		Speed = 5;
	}


	//POLYMORPHISM
	public override void MoveVehicle(Vector3 direction)
	{
		stutterTimer += Time.deltaTime;

		// Since the tank has a defective engine, it stutters
		if (stutterTimer < 0.2f)
		{
			direction = Vector3.zero;
		}
		else if (stutterTimer >= 1f)
		{
			stutterTimer = 0;
		}

		base.MoveVehicle(direction);
	}
}