using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "Store", menuName = "Store/Storefront")]
public class Store : ScriptableObject
{

	public Objects Available, Purchased;
	public SOInt Kills;

	public UnityEvent MadePurchase;
	
	public void MakePurchase(PurchasableObject obj)
	{
		for (var i = 0; i < Available.ObjectList.Count; i++)
		{
			PurchasableObject availableObject = Available.ObjectList[i] as PurchasableObject;
			if (availableObject == obj && Kills.Value >= availableObject.Value)
			{
				Kills.Value -= availableObject.Value;
				Purchased.ObjectList.Add(obj);
				Available.ObjectList.Remove(availableObject);
				MadePurchase.Invoke();
			}
		}
	}
}
