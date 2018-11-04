using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyContact : MonoBehaviour
{
	public SOInt CurrentKills;
	
	private void OnCollisionEnter(Collision other)
	{
		Debug.Log("Collision");
		if (other.transform.CompareTag("Projectile"))
		{
			CurrentKills.Value++;
				Destroy(other.gameObject);
				Destroy(gameObject);
			}
		else if (other.transform.CompareTag("Player"))
		{
			CurrentKills.Value = 0;
			SceneManager.LoadScene("Level01");
		}
		else if (other.transform.CompareTag("Super"))
		{
			CurrentKills.Value++;
			Destroy(gameObject);
		}
	}
}
