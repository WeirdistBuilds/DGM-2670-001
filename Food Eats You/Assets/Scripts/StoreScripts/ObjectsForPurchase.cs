using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ObjectsForPurchase", menuName = "Store/ObjectsForPurchase")]

public class ObjectsForPurchase : ScriptableObject
{
    public List<ObjectForPurchase> ObjectList;
}
