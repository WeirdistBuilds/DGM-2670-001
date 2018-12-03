using UnityEngine;

[CreateAssetMenu(fileName = "NewSpawnIncreaser", menuName = "Scriptable Objects/SpawnIncreaser")]
public class SpawnIncreaser : ScriptableObject
{
	public SOFloat DefaultSpawnSpeed;
	public SOFloat SpawnSpeed;
	public SOInt Kills;
	public SOInt MaxValue;
	public SOFloat Percentage;
	
	public void Call()
	{
		var killsValue = Kills.Value;
		if (killsValue <= MaxValue.Value && killsValue > 0)
		SpawnSpeed.value = DefaultSpawnSpeed.Value - ( killsValue / Percentage.Value);
	}
}
