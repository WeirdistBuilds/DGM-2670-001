﻿using System.Collections;
using UnityEngine;

public class SuperSpinObject : MonoBehaviour
{
    public SOFloat PlayerSpin;
    public SOFloat NormalSpin;
    public SOFloat SuperSpin;
    public SOInt TimeLeft;
    public SOInt DefaultTime;
    
    public SOBool isRunning;

    public void Start()
    {
        TimeLeft.Value = DefaultTime.Value;
        ChangeSpeed();
        if (!isRunning.Value)
        {
            StartCoroutine(Timer());            
        }
    }
    
    
    private IEnumerator Timer()
    {
        isRunning.Value = true;
        while (TimeLeft.Value > 0)
        {
            TimeLeft.Value--;
            yield return new WaitForSeconds(1);
        }
        ResetSpin();
        Destroy(gameObject);
    }
    
    private void ChangeSpeed()
    {
        PlayerSpin.value = SuperSpin.Value;
    }

    private void ResetSpin()
    {
        TimeLeft.Value = 0;
        PlayerSpin.value = NormalSpin.Value;
        isRunning.Value = false;
    }
    
}