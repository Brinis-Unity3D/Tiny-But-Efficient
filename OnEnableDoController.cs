using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnEnableDoController : MonoBehaviour
{
    // Start is called before the first frame update
    public float doAfterDelay = 0;
    public UnityEvent onEnable;
    public UnityEvent onDisable;
    void OnEnable()
    {
        Invoke("Do", doAfterDelay);
    }
    void Do()
    {
        onEnable.Invoke();
    }


    private void OnDisable()
    {
        Invoke("OnDisableDo", doAfterDelay);
    }

    void OnDisableDo()
    {
        onDisable.Invoke();
    }
}
