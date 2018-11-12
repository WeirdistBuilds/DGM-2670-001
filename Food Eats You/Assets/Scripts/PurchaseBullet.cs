using System.Collections;
using UnityEngine;

public class PurchaseBullet : MonoBehaviour
{
    public GameObject Item;
    public SOMovePattern ItemMovePattern;
    public SOInt TimeLeft;
    public SOInt DefaultTime;
    public SOString NewTag;
    public SOFloat NewSpeed;
    
    private string oldTag;
    private float oldSpeed;
    

    public void Call()
    {
        oldTag = Item.transform.tag;
        oldSpeed = ItemMovePattern.MoveY.Value;
        TimeLeft.Value = DefaultTime.Value;
        
        ChangeTag(NewTag);
        ChangeSpeed(NewSpeed);
        StartCoroutine(Timer());
    }
    
    
    private IEnumerator Timer()
    {
        while (TimeLeft.Value > 0)
        {
            Debug.Log("Timer Ran from " + TimeLeft.Value + " to next value.");
            TimeLeft.Value--;
            yield return new WaitForSeconds(1);
        }
        Reset();
        Debug.Log("Timer Stopped.");
    }
    
    private void ChangeTag(SOString newTag)
    {
        Item.transform.tag = newTag.Value;
    }

    private void ChangeSpeed(SOFloat newSpeed)
    {
        ItemMovePattern.MoveY = newSpeed;
    }

    private void Reset()
    {
        TimeLeft.Value = 0;
        Item.transform.tag = oldTag;
        ItemMovePattern.MoveY.value = oldSpeed;
    }
    
}