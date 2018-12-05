using UnityEngine;

[CreateAssetMenu(fileName = "NewQuit", menuName = "Scriptable Objects/SOQuit")]
public class SOQuit : ScriptableObject
{

	public void Call()
	{
		Application.Quit();
	}
	
}
