using UnityEngine;

[CreateAssetMenu(fileName = "ObjectForPurchase", menuName = "Store/ObjectForPurchase")]

public class ObjectForPurchase : ScriptableObject
{

    public Object Item;
    public Sprite PreviewArt;
    public int UsageCount = 3;
    public int Value;
    public bool Upgrade;
    public ObjectForPurchase UpgradeFrom;

    public bool Perpetual;
    public bool Instantiatable;

    public void CreateItem()
    {
        for (int i = 0; i < UsageCount; i++)
        {
            if (Instantiatable && Item is GameObject)
            {
                Instantiate(Item);
            }
        }
    }

    public void Used()
    {
        UsageCount--;
    }
}
