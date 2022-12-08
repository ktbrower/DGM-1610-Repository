using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineBehaviour : MonoBehaviour
{
   public bool canRun;
    public UnityEvent startEvent, startCountEvent, repeatCountEvent, endCountEvent, repeatUntilFalseEvent;

    public IntData counterNum;
    public float seconds = 3.0f;
    private WaitForSeconds wfsObj;
    private WaitForFixedUpdate wffuObj;

    private void Start()
    {
        wffuObj = new WaitForFixedUpdate();
        wfsObj = new WaitForSeconds(seconds);
        startEvent.Invoke();
    }
    public void StartCounting()
    {
        StartCoroutine(Counting());
    }
    
    private IEnumerator Counting()
    {
       
        
        startCountEvent.Invoke();
        yield return wfsObj;
        while (counterNum.value > 0)
        {
            Debug.Log(counterNum);
            repeatCountEvent.Invoke();
            counterNum.value--;
            
        }

        endCountEvent.Invoke();
    }

    public void StartRepeatUntilFalse()
    {
        canRun = true;
        StartCoroutine(RepeatUntilFalse());
    }
   private IEnumerator RepeatUntilFalse()
    {
        while (canRun)
        {
                yield return wfsObj;
                repeatUntilFalseEvent.Invoke();
        }
        
    }

}
