using UnityEngine;

[CreateAssetMenu(fileName = "MovePatternNotGrounded")]
public class MovePatternNotGrounded : MovePattern {
    
    public override void Invoke(CharacterController controller, Transform transform)
    {
        base.Invoke(controller, transform);
        Move(transform);
        Move(controller);
    }
}
