using UnityEngine;

[CreateAssetMenu(fileName = "ObjectForPurchaseGenerator", menuName = "Store/ObjectForPurchaseGenerator")]
public class ObjectForPurchaseGenerator : ScriptableObject
{

	public ObjectsForPurchase Purchased;
	
	public void Call ()
	{
		var obj = Purchased.ObjectList[Purchased.ObjectList.Count - 1];
		obj.CreateItem();
	}
	
}
