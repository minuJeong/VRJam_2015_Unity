using UnityEngine;
using System.Collections;

public class Pawn : MonoBehaviour
{
	public float Acceleration;
	public float Speed;
	public float MaxSpeed;
	
	// Update is called once per frame
	void Update ()
	{
		transform.position += transform.forward * Speed;
		Speed += Acceleration;
		if (Speed > MaxSpeed) {
			Speed = MaxSpeed;
		}

		transform.Rotate (new Vector3 (Input.GetAxis ("Vertical"), Input.GetAxis ("Horizontal")));
	}
}
