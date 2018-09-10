using UnityEngine;

[CreateAssetMenu]
public class MovePattern : ScriptableObject {

	//public float speed = 6.0F;
	public FloatData JumpSpeed;
	public FloatData Gravity;

	public FloatData MoveX, MoveY, MoveZ;
	public FloatData RotX, RotY, RotZ;
	
	//vector3s default to zero
	private Vector3 moveDirection;
	private Vector3 rotDirection;

	public void Invoke(CharacterController controller, Transform transform)
	{
		
	if (controller.isGrounded)
	{
		//Accessing "value" from the FloatData class
		moveDirection.Set(MoveX.Value, MoveY.Value, MoveZ.Value);
		rotDirection.Set(RotX.Value, RotY.Value, RotZ.Value);
			
		transform.Rotate(rotDirection);
			
		moveDirection = transform.TransformDirection(moveDirection);
		
		//moveDirection *= speed; replaced by value in FloatInput
		if (Input.GetButton("Jump"))
			moveDirection.y = JumpSpeed.Value;

	}

	moveDirection.y -= Gravity.Value * Time.deltaTime;
	controller.Move(moveDirection * Time.deltaTime);
	}
	
}
