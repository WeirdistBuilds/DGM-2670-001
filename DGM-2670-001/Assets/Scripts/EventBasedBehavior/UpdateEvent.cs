﻿using UnityEngine;
using UnityEngine.Events;

public class UpdateEvent : MonoBehaviour
{
    public UnityEvent Event;

    private void Update()
    {
        Event.Invoke();
    }

}