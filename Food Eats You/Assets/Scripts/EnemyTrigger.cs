using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyTrigger : MonoBehaviour
{
	public SOInt CurrentKills;
	public SOInt BulletTimer;
	public SOInt SpinTimer;
	public SOInt DefaultTime;
	
	private void OnTriggerEnter(Collider other)
	{
		Debug.Log(gameObject.name + " has been triggered by " + other.gameObject.name);
		if (other.transform.CompareTag("Item"))
		{
			CurrentKills.Value++;
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
			BulletTimer.Value = DefaultTime.Value;
			SpinTimer.Value = DefaultTime.Value;
			SceneManager.LoadScene("Level01");
		}
	}
}