using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.InteropServices;

public class MidtermPlugin : MonoBehaviour
{
    [DllImport("MidtermPlugin")]
    private static extern int PrintANumber();

    [DllImport("MidtermPlugin")]
    private static extern float ModifyWinLoss(float f1, float f2);


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(PrintANumber());
        Debug.Log(ModifyWinLoss(3.0f, 5.0f));
    }
}
