using UnityEngine;

public class CollisionDebug : MonoBehaviour {
	private void OnCollisionEnter(Collision other)
	{
		Debug.Log("COLLIDING!");
	}
}
