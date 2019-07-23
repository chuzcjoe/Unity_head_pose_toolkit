using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using System.Threading;
using System;

public class controlText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void TestFunc()
    {
        Debug.Log("Test");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        //GameObject save = GameObject.Find("Canvas/save_info");

        if (this.GetComponent<Text>().text == "Saved !")
        {
            DateTime Start = DateTime.Now;

            while ((DateTime.Now.Subtract(Start).TotalMilliseconds) < 500.0f)
            {
                this.GetComponent<Text>().text = "Saved !";
            }
            
        }

        this.GetComponent<Text>().text = " ";

    }
}
