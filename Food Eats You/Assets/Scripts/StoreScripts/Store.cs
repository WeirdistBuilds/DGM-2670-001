using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Store", menuName = "Store/Storefront")]

public class Store : MonoBehaviour
{
    public ObjectsForPurchase Available;
    public ObjectsForPurchase Purchased;
    public GameObject Canvas;
    public GameObject Button;
    public SOInt Cash;

    public UnityEvent MadePurchase;

    private void OnEnable()
    {
        foreach (var item in Available.ObjectList)
        {
            var newItem = item;
        }
    }

    public void BuildUI()
    {
        var newCanvas = Instantiate(Canvas);
        foreach (var obj in Available.ObjectList)
        {
            var newButton = Instantiate(Button, newCanvas.GetComponentInChildren <VerticalLayoutGroup>().transform);
            var buttonComponent = newButton.GetComponent<Button>();
            var imageComponent = newButton.GetComponent<Image>();
            imageComponent.sprite = obj.PreviewArt;
            buttonComponent.onClick.AddListener(() => { MakePurchase(obj);});
            buttonComponent.onClick.AddListener(() => { DisableButton(obj, buttonComponent);});

            var label = newButton.GetComponentInChildren<Text>();
            label.text = obj.name;
        }
    }

    private void DisableButton(ObjectForPurchase obj, Button btn)
    {
        if (obj.Perpetual)
        {
            btn.interactable = false;
            btn.onClick.RemoveAllListeners();
        }
    }

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