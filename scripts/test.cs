using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour
{

   //Text ROTx;

   

   float x = 0.0f;
   float y = 0.0f;
   float z = 0.0f;

  
    // Use this for initialization
    void Start()
   {
       
   }
   
   private void Awake()
   {
      
   }

    public void show_rotation()

    {
        GameObject rot = GameObject.Find("rentou");

        //x = rot.transform.localEulerAngles.x;
        //y = rot.transform.localEulerAngles.y;
        //z = rot.transform.localEulerAngles.z;

        x = rot.transform.localEulerAngles.x;
        y = rot.transform.localEulerAngles.y;
        z = rot.transform.localEulerAngles.z;

        //Vector3 rotationVector = new Vector3(x, y, z);
        //Quaternion rotation = Quaternion.Euler(rotationVector);


        if (x > 180.0f)
        {
            //if (x > 180.0f)
            //{
            //    x = x;
            //}
            x = 360.0f - x;

        }

        else
        {
            x = -x;
        }
        
        
        
        
        if (y > 180.0f)
        {
            y = y - 360.0f;
            
        }
        
        
        if (z > 180.0f)
        {
            z = z - 360.0f;
            
        }

        this.GetComponent<Text>().text = x.ToString("F2")+ "        "+ y.ToString("F2")+"       "+ 
                                          z.ToString("F2");

    }

    void Update()
   {
        //x = r.transform.localEulerAngles.x;
        //y = r.transform.localEulerAngles.y;
        //z = r.transform.localEulerAngles.z;
        //
        //
        //Vector3 rotationVector = new Vector3(x, y, z);
        //Quaternion rotation = Quaternion.Euler(rotationVector);
        //
        //Text_currencyText.text = rotation.x.ToString();
        show_rotation();
   }
}
