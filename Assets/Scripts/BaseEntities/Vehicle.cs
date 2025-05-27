using UnityEngine;

public class Vehicle : MonoBehaviour
{
	//ENCAPSULATION
	private float speed;
	public float Speed
	{
		get { return speed; }
		protected set
		{
			if (value <= 0)
			{
				Debug.LogWarning("Speed cannot be negative or 0. Setting it to 1.");
				speed = 1;
			}
			else
			{
				speed = value;
			}
		}
	}
	void Update()
	{
		MoveVehicle(Vector3.forward);
	} 

	//ABSTRACTION
	public virtual void MoveVehicle(Vector3 direction)
	{
		transform.Translate(direction * Speed * Time.deltaTime);
	}
}