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
    private bool isRunning;

    private void Start()
    {
        TimeLeft.Value = 0;
        oldTag = Item.transform.tag;
        oldSpeed = ItemMovePattern.MoveY.Value;
        isRunning = false;
    }

    public void Call()
    {
        if (!isRunning)
        {
            TimeLeft.Value = DefaultTime.Value;
        
            ChangeTag(NewTag);
            ChangeSpeed(NewSpeed);
            StartCoroutine(Timer());
            isRunning = true;
        }
    }
    
    private IEnumerator Timer()
    {
        while (TimeLeft.Value > 0)
        {
            Debug.Log("Timer Ran from " + TimeLeft.Value + " to next value.");
            TimeLeft.Value--;
            yield return new WaitForSeconds(1);
        }
        ResetBullet();
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

    private void ResetBullet()
    {
        TimeLeft.Value = 0;
        Item.transform.tag = oldTag;
        ItemMovePattern.MoveY.value = oldSpeed;
        isRunning = false;
    }
    
}