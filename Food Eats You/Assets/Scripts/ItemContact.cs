using UnityEngine;

public class ItemContact : MonoBehaviour {
	private void OnCollisionEnter(Collision other)
	{
		Debug.Log("Collision");
		if (other.transform.CompareTag("Projectile"))
			{
				Destroy(other.gameObject);
				Destroy(gameObject);
			}
	}
}
