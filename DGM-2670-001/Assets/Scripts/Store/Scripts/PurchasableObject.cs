using UnityEngine;

[CreateAssetMenu(fileName = "Purchase", menuName = "Store/Purchasable")]
public class PurchasableObject : ScriptableObject
{
    public int Value;
    public Object Item;
}
