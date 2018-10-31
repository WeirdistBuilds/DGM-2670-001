using UnityEngine;

[CreateAssetMenu(fileName = "NewDestroyAfterDelay", menuName = "Scriptable Objects/SODestroyAfterDelay")]
public class SODestroyAfterDelay : ScriptableObject
{

	public SOFloat Time;
	
	public void Call(GameObject instance)
	{
		Destroy(instance, Time.Value);
	}
	
}
