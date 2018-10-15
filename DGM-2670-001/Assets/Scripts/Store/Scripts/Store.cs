using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Store", menuName = "Store/Storefront")]
public class Store : ScriptableObject
{

	public Objects Available, Purchased;
	
	public void MakePurchase(Object obj)
	{
		for (var i = 0; i < Available.ObjectList.Count; i++)
		{
			var availableObject = Available.ObjectList[i];
			if (availableObject == obj)
			{
				Purchased.ObjectList.Add(obj);
				Available.ObjectList.Remove(availableObject);
			}
		}
	}
}
