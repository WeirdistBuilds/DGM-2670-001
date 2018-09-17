using UnityEngine;
[CreateAssetMenu(fileName = "FloatInput")]
public class FloatBool : FloatInput {

	public override float Value
	{
		get
		{
			if (Input.GetButton(InputType))
			{
				return value;
			}
				return 0;
		}
	}
	
}
