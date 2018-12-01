using System.Collections;
using UnityEngine;

public class SuperBulletObject : MonoBehaviour
{
    public GameObject Item;
    
    public SOFloat ItemSpeed;
    
    public SOInt TimeLeft;
    public SOInt DefaultTime;
    
    public SOString SuperTag;
    public SOString DefaultTag;
    
    public SOFloat SuperSpeed;
    public SOFloat DefaultSpeed;
    

    private void Start()
    {
        TimeLeft.Value = DefaultTime.Value;
        ChangeTag(SuperTag);
        ChangeSpeed(SuperSpeed);
        StartCoroutine(Timer());
    }
    
    private IEnumerator Timer()
    {
        while (TimeLeft.Value > 0)
        {
            TimeLeft.Value--;
            yield return new WaitForSeconds(1);
        }
        ResetBullet();
        Destroy(this);
    }
    
    private void ChangeTag(SOString newTag)
    {
        Item.transform.tag = newTag.Value;
    }

    private void ChangeSpeed(SOFloat newSpeed)
    {
        ItemSpeed.value = newSpeed.Value;
    }

    private void ResetBullet()
    {
        TimeLeft.Value = 0;
        Item.transform.tag = DefaultTag.Value;
        ItemSpeed.value = DefaultSpeed.Value;
    }
    
}