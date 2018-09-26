using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutputChildren : MonoBehaviour
{
    private Transform[] allChildren = GetComponentsInChildren<Transform>();
    private dynamic List<GameObject> childObjects;
	
    void Start ()
    {
        foreach (Transform child in allChildren)
        {
            childObjects.Add(child.gameObject);
        }
		
        for (int i = 0; i < childObjects.Count - 1; i++)
        {
            Debug.Log(childObjects[i]);
        }
    }
}
