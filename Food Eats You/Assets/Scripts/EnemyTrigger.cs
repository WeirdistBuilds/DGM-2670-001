using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyTrigger : MonoBehaviour
{
	public SOInt CurrentKills;
	
	private void OnTriggerEnter(Collider other)
	{
		Debug.Log(gameObject.name + " has been triggered by " + other.gameObject.name);
		if (other.transform.CompareTag("Item"))
		{
			CurrentKills.Value++;
				Destroy(other.gameObject);
				Destroy(gameObject);
		}
		else if (other.transform.CompareTag("Super"))
		{
			CurrentKills.Value++;
			Destroy(gameObject);
		}
		else if (other.transform.CompareTag("Player"))
		{
			CurrentKills.Value = 0;
			SceneManager.LoadScene("Level01");
		}
		
	}
}