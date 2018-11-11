using System.Collections;
using UnityEngine;

public class PurchaseBullet : MonoBehaviour
{
    public GameObject Item;
    public SOMovePattern ItemMovePattern;
    public SOInt TimeLeft;
    public SOString NewTag;
    public SOFloat NewSpeed;
    public bool IsRunning;
    
    private string oldTag;
    private SOFloat oldSpeed;
    private SOInt StartingTime;

    public void Call()
    {
        StartingTime = TimeLeft;
        StartCoroutine(Countdown());
        ChangeTag(NewTag);
        ChangeSpeed(NewSpeed);
        IsRunning = true;
    }
    
    
    public void ChangeTag(SOString newTag)
    {
        oldTag = Item.transform.tag;
        Item.transform.tag = newTag.Value;
    }

    public void ChangeSpeed(SOFloat newSpeed)
    {
        oldSpeed = ItemMovePattern.MoveY;
        ItemMovePattern.MoveY = newSpeed;
    }
    
    private IEnumerator Countdown()
    {
        TimeLeft.Value--;
        yield return new WaitForSeconds(1);
    }

    void Update()
    {
        if (TimeLeft.Value <= 0 && IsRunning)
        {
            StopCoroutine(Countdown());
            TimeLeft = StartingTime;
            Item.transform.tag = oldTag;
            ItemMovePattern.MoveY = oldSpeed;
            IsRunning = false;
        }
    }
}