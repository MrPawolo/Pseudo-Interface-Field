using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTestInterface : MonoBehaviour, ITest
{
    [SerializeField] string textToLog;
    public void Test()
    {
        Debug.Log(textToLog);
    }
}
