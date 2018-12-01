using System.Collections;
using UnityEngine;

public class SuperSpinObject : MonoBehaviour
{
    public SOFloat PlayerSpin;
    public SOFloat NormalSpin;
    public SOFloat SuperSpin;
    public SOInt TimeLeft;
    public SOInt DefaultTime;

    public void Start()
    {
        TimeLeft.Value = DefaultTime.Value;
        ChangeSpeed();
        StartCoroutine(Timer());
    }
    
    
    private IEnumerator Timer()
    {
        while (TimeLeft.Value > 0)
        {
            TimeLeft.Value--;
            yield return new WaitForSeconds(1);
        }
        ResetSpin();
        Destroy(this);
    }
    
    private void ChangeSpeed()
    {
        PlayerSpin.value = SuperSpin.Value;
    }

    private void ResetSpin()
    {
        TimeLeft.Value = 0;
        PlayerSpin.value = NormalSpin.Value;
    }
    
}