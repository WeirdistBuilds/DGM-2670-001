using System.Collections;
using UnityEngine;

public class PurchaseSpin : MonoBehaviour
{
    public SOMovePattern PlayerMovePattern;
    public SOInt TimeLeft;
    public SOInt DefaultTime;
    public SOFloat NewSpeed;
    public float oldSpeed;
    
    public void Call()
    {
        oldSpeed = PlayerMovePattern.RotY.Value;
        TimeLeft.Value = DefaultTime.Value;
        
        ChangeSpeed(NewSpeed);
        StartCoroutine(Timer());
    }
    
    
    private IEnumerator Timer()
    {
        while (TimeLeft.Value > 0)
        {
            TimeLeft.Value--;
            yield return new WaitForSeconds(1);
        }
        Reset();
    }
    
    private void ChangeSpeed(SOFloat newSpeed)
    {
        PlayerMovePattern.RotY = newSpeed;
    }

    private void Reset()
    {
        TimeLeft.Value = 0;
        PlayerMovePattern.RotY.value = oldSpeed;
    }
    
}