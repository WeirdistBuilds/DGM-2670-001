using UnityEngine;

public class ItemContact : MonoBehaviour {
	private void OnTriggerEnter(Collider other)
	{
		Debug.Log(gameObject.name + " has been triggered by " + other.gameObject.name);
		if (other.transform.CompareTag("Item"))
		{
			Destroy(other.gameObject);
			Destroy(gameObject);
		}
	}

	
}
