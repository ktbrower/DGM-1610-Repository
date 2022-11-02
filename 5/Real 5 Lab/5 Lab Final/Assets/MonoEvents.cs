using System.Collections;
using UnityEngine;
using UnityEngine.Events;
public class MonoEvents : MonoBehaviour
{
  public UnityEvent awakeEvent, startEvent, onEnableEvent;
  public float holdTime;

  private void Awake()
  {
    awakeEvent.Invoke();
  }

  private IEnumerator Start()
  {
    yield return new WaitForSeconds(holdTime);
    startEvent.Invoke();
  }

  private void OnEnable()
  {
    onEnableEvent.Invoke();
  }
}

