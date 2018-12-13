using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Store", menuName = "Store/Storefront")]

public class Store : ScriptableObject
{
    public ObjectsForPurchase Available;
    public ObjectsForPurchase Purchased;
    public SOInt Cash;

    public UnityEvent MadePurchase;

    public void MakePurchase(ObjectForPurchase obj)
    {
        for (var i = 0; i < Available.ObjectList.Count; i++)
        {
            var availableObject = Available.ObjectList[i];
            
            if (availableObject != obj || Cash.Value < availableObject.Value) continue;
            Cash.Value -= availableObject.Value;
            Purchased.ObjectList.Add(obj);

            if (availableObject.Perpetual)
            {
                Available.ObjectList.Remove(availableObject);
            }
            MadePurchase.Invoke();
        }
    }
    
}