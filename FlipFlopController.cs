using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FlipFlopController : MonoBehaviour
{
    // Start is called before the first frame update
    public bool value = false;
    public UnityEvent OnTrue;
    public UnityEvent OnFalse;
    
    public void FlipFlop()
    {
        value = !value;
        if(value) 
            OnTrue.Invoke();
        else      
            OnFalse.Invoke();
    }
}
