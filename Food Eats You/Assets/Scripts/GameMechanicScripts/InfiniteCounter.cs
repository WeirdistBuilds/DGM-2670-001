using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class InfiniteCounter : MonoBehaviour
{
    public UnityEvent OnCount;
    public SOFloat Seconds;

    IEnumerator Start()
    {
        while (true)
        {
            OnCount.Invoke();
            yield return new WaitForSeconds(Seconds.Value);
        }
    }
}
