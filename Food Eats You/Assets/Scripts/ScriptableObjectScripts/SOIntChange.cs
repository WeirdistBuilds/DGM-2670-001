using UnityEngine;

[CreateAssetMenu(fileName = "NewIntChange", menuName = "Scriptable Objects/SOIntChange")]
public class SOIntChange : ScriptableObject {
	
	public SOInt Integer;

	public void Call(SOInt soInt)
	{
		soInt.Value = Integer.Value;
	}
	
}
