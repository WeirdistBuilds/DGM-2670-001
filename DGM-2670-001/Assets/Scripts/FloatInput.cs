using UnityEngine;

[CreateAssetMenu(fileName = "FloatInput", menuName = "KH/FloatData")]

public class FloatInput : FloatData
//Inherits from FloatData (FloatInput, FloatData, ScriptableObject)
{

	public string InputType;
	
	//Overrides the value of FloatData
	public override float Value
	{
		get { return Input.GetAxis(InputType) * value;}
	}
}
