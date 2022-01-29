using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceFieldTest : MonoBehaviour
{
    [SerializeField] SingleInterfaceField<ITest> iTest;
    [SerializeField] List<SingleInterfaceField<ITest>> iTestList = new();
    [SerializeField] SingleInterfaceField<ITest>[] iTestArray;
    private void OnValidate()
    {
        iTest.Validate();
        InterfaceHelper.ValidateInterfaces(ref iTestList);
        InterfaceHelper.ValidateInterfaces(ref iTestArray);
    }

    [ContextMenu("CallSingeInterface")]
    void CallSingleInterface()
    {
        if (iTest.Interface != null)
        {
            iTest.Interface.Test();
        }
    }
    [ContextMenu("CallListInterface")]
    void CallListInterface()
    {
        for (int i = 0; i < iTestList.Count; i++)
        {
            if (iTestList[i].Interface != null)
                iTestList[i].Interface.Test();
        }
    }

    [ContextMenu("CallArrayInterface")]
    void CallArrayInterface()
    {

        for (int i = 0; i < iTestArray.Length; i++)
        {
            if (iTestArray[i].Interface != null)
                iTestArray[i].Interface.Test();
        }
    }
}


