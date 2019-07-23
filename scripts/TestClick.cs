using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestClick : MonoBehaviour
{
    float old_x = 0.107f;
    float old_y = 1.812f;
    float old_z = -0.16f;

    float scale = 0.020f;

 




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void OnClick()
    {

        GameObject rentou = GameObject.Find("rentou");
        GameObject left = GameObject.Find("rentou/left");
        GameObject right = GameObject.Find("rentou/right");
        rentou.transform.position = new Vector3(old_x, old_y, old_z);
        rentou.transform.rotation = Quaternion.Euler(0, 0, 0);
        left.transform.rotation = Quaternion.Euler(0, -90, 0);
        right.transform.rotation = Quaternion.Euler(0, -90, 0);
        rentou.transform.localScale = new Vector3(scale, scale, scale);


    }
}
