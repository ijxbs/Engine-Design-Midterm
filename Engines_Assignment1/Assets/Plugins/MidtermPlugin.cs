using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.InteropServices;

public class MidtermPlugin : MonoBehaviour
{
    [DllImport("MidtermPlugin")]
    private static extern int PrintANumber();

    //actually for modifying color, not win/loss
    [DllImport("MidtermPlugin")]
    private static extern float ModifyWinLoss(float f1, float f2);

    [SerializeField] private Material mat;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            mat.color = Color.black;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(PrintANumber());

        //modify color, not win loss
        Debug.Log(ModifyWinLoss(3.0f, 5.0f));
    }
}
