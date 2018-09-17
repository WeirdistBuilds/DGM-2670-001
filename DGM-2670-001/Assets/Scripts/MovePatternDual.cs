using UnityEngine;

[CreateAssetMenu(fileName = "MovePatternDual")]
public class MovePatternDual : MovePattern
{
    private bool canJump;
    private bool canDoubleJump;

    public override void Invoke(CharacterController controller, Transform transform)
    {
        if (controller.isGrounded)
        {
            canJump = true;
        }
            if (canJump)
            {
                Move(transform);
                canDoubleJump = false;
            }
        
        Move(controller);
    }
}
