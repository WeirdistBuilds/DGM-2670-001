using System.Collections;
using UnityEngine;

public class PurchaseSpin : MonoBehaviour
{
    public SOFloat PlayerSpin;
    public SOFloat NormalSpin;
    public SOFloat SuperSpin;
    public SOInt TimeLeft;
    public SOInt DefaultTime;
    
    private bool isRunning;

    private void Start()
    {
        ResetSpin();
    }

    public void Call()
    {
        if (!isRunning)
        {
            TimeLeft.Value = DefaultTime.Value;
            ChangeSpeed();
            StartCoroutine(Timer());
            isRunning = true;
        }
    }
    
    
    private IEnumerator Timer()
    {
        while (TimeLeft.Value > 0)
        {
            TimeLeft.Value--;
            yield return new WaitForSeconds(1);
        }
        ResetSpin();
    }
    
    private void ChangeSpeed()
    {
        PlayerSpin.value = SuperSpin.Value;
    }

    private void ResetSpin()
    {
        TimeLeft.Value = 0;
        PlayerSpin.value = NormalSpin.Value;
        isRunning = false;
    }
    
}