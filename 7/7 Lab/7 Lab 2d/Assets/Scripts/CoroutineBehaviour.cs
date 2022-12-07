using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineBehaviour : MonoBehaviour
{
    public UnityEvent startEvent, repeatEvent, endEvent;

    public IntData counterNum;
    public float seconds = 3.0f;
    private WaitForSeconds wfsObj;
    private WaitForFixedUpdate wffuObj;

    IEnumerator Start()
    {
        wffuObj = new WaitForFixedUpdate();
        wfsObj = new WaitForSeconds(seconds);
        
        startEvent.Invoke();
        yield return wfsObj;
        while (counterNum.value > 0)
        {
            Debug.Log(counterNum);
            repeatEvent.Invoke();
            counterNum.value--;
            
        }

        endEvent.Invoke();
    }


}
