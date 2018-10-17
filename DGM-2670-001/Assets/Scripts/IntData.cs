using UnityEngine;

[CreateAssetMenu(fileName = "NewInt", menuName = "KH/IntData")]

public class IntData : ScriptableObject
{
	public int value;
	
	public virtual float Value
	{
		get { return value;}
		//set { Value = value; }
	}
	
}
