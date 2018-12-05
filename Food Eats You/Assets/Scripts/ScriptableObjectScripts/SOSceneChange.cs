using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "NewSceneChange", menuName = "Scriptable Objects/SOSceneChange")]
public class SOSceneChange : ScriptableObject
{
	public int SceneIndex;

	public void Call()
	{
		SceneManager.LoadScene(SceneIndex);
	}
	
}
