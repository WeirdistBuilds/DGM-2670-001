using UnityEngine;

[CreateAssetMenu(fileName = "NewMove", menuName = "MovePattern")]
public class MovePattern : ScriptableObject {

	//public float speed = 6.0F;
	public FloatData Gravity;

	public FloatData MoveX, MoveY, MoveZ;
	public FloatData RotX, RotY, RotZ;
	
	//vector3s default to zero
	protected Vector3 moveDirection;
	private Vector3 rotDirection;

	public virtual void Invoke(CharacterController controller, Transform transform)
	{
		if (controller.isGrounded)
		{
			Move(transform);
		}
		
		Move(controller);
	}

	protected void Move(CharacterController controller)
	{
		moveDirection.y -= Gravity.Value * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);
	}

	protected void Move(Transform transform)
	{
		//Accessing "value" from the FloatData class
		moveDirection.Set(MoveX.Value, MoveY.Value, MoveZ.Value);
		rotDirection.Set(RotX.Value, RotY.Value, RotZ.Value);
		transform.Rotate(rotDirection);
		moveDirection = transform.TransformDirection(moveDirection);
	}
}
