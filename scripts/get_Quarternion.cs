using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class get_Quarternion : MonoBehaviour
{

    float xx = 0.0f;
    float yy = 0.0f;
    float zz = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    

    public void show()

    {
        GameObject rt = GameObject.Find("rentou");

        //xx = rt.transform.eulerAngles.x;
        //yy = rt.transform.eulerAngles.y;
        //zz = rt.transform.eulerAngles.z;

        //Vector3 rotationVector = new Vector3(xx, yy, zz);
        //Quaternion rotation = Quaternion.Euler(rotationVector);

      

        this.GetComponent<Text>().text = "(  " + rt.transform.rotation.x.ToString("F5") + ",  " + rt.transform.rotation.y.ToString("F5") + ",  " +
            rt.transform.rotation.z.ToString("F5") + ",  " + rt.transform.rotation.w.ToString("F5") + "  )";

    }
    // Update is called once per frame
    void Update()
    {
        show();
    }
}
