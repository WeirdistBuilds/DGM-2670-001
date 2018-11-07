using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "Store", menuName = "Store/Storefront")]
public class Store : ScriptableObject
{

	public Objects Available, Purchased;
	public SOInt Kills;
	public int TotalValue = 3000;

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

	public void PurchaseAll()
	{
		if (Kills.Value >= TotalValue)
		{
			Kills.Value -= TotalValue;
			for (var i = Available.ObjectList.Count; i > 0; i--)
			{
				var item = Available.ObjectList[i];
				Purchased.ObjectList.Add(item);
				Available.ObjectList.RemoveAt(i);
			}
		}
	}
}
