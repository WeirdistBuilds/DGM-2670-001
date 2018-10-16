﻿using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class InfiniteCounter : MonoBehaviour
{
    public UnityEvent OnCount;
    public float Seconds = 1;

    IEnumerator Start()
    {
        while (true)
        {
            OnCount.Invoke();
            yield return new WaitForSeconds(Seconds);
        }
    }
}
