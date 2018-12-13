using UnityEngine;

[CreateAssetMenu(fileName = "ObjectForPurchase", menuName = "Store/ObjectForPurchase")]

public class ObjectForPurchase : ScriptableObject
{

    public Object Item;
    public int Value;

    public bool Perpetual;
    public bool Instantiatable;

    public void CreateItem()
    {
        if (Instantiatable && Item is GameObject)
        {
                Instantiate(Item);
        }
    }
    
}
