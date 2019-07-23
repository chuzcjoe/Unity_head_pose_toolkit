using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{

    //float old_x = 0.071f;
    //float old_y = 1.84f;
    //float old_z = 0.63f;

    float old_x = 0.107f;
    float old_y = 1.812f;
    float old_z = -0.16f;


    // Start is called before the first frame update
    void Start()
    {
        float RotX = 0.0f;
        
    }

    // Update is called once per frame
    float x = 0.0f;
    float y = 0.0f;
    float z = 0.0f;
    //float scale = 0.01f;
    float scale = 0.020f;
    float MoveSpeed = 0.2f;

    void Update()
    {

        if (Input.GetKey(KeyCode.R))
        {
            transform.position = new Vector3(old_x, old_y, old_z);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            transform.localScale = new Vector3(scale,scale,scale);
        }


        if (Input.GetKey(KeyCode.Equals))
        {


            //放大
            transform.localScale *= 1.01f;
        }


        if (Input.GetKey(KeyCode.Minus))
        {


            //缩小
            transform.localScale *= 0.99f;
        }


        if (Input.GetKey(KeyCode.W))
       {
       
       
           //向上转
           //transform代表当前对象
           transform.Rotate(Vector3.left * Time.deltaTime * 10, Space.Self);
       }
       if (Input.GetKey(KeyCode.S))
       {
       
       
           //向下转
           transform.Rotate(Vector3.right * Time.deltaTime * 10, Space.Self);
       }
       if (Input.GetKey(KeyCode.A))
       {
           //向左转
           transform.Rotate(Vector3.up * Time.deltaTime * 10, Space.Self);
       }
       if (Input.GetKey(KeyCode.D))
       {
           //向右转
           transform.Rotate(Vector3.down * Time.deltaTime * 10, Space.Self);
       }

        if (Input.GetKey(KeyCode.E))
        {
            //向右转
            transform.Rotate(Vector3.forward * Time.deltaTime * 10, Space.Self);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            //向右转
            transform.Rotate(Vector3.back * Time.deltaTime * 10, Space.Self);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * MoveSpeed * Time.deltaTime, Space.World);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * MoveSpeed * Time.deltaTime, Space.World);
        }


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.right * MoveSpeed * Time.deltaTime, Space.World);
        }


        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.left * MoveSpeed * Time.deltaTime, Space.World);
        }

        //x = this.transform.localEulerAngles.x;
        //y = this.transform.localEulerAngles.y;
        //z = this.transform.localEulerAngles.z;
        //
        //
        //Vector3 rotationVector = new Vector3(x, y, z);
        //Quaternion rotation = Quaternion.Euler(rotationVector);
        //print("Quarternion: ("+rotation.x+","+rotation.y+","+rotation.z+","+rotation.w+")");
        //
        //if (this.transform.localEulerAngles.x > 180f)
        //{
        //     x = this.transform.localEulerAngles.x-360f;
        //    
        //}
        //
        //
        //if (this.transform.localEulerAngles.y > 180f)
        //{
        //    y = this.transform.localEulerAngles.y - 360f;
        //    
        //}
        //
        //
        //if (this.transform.localEulerAngles.z > 180f)
        //{
        //    z = this.transform.localEulerAngles.z - 360f;
        //    
        //}
        //
        //
        //print("pitch:"+x+"    yaw:"+y+"   roll:"+z);
        //Vector3 rotationVector = new Vector3(87.730f, -89.317f, -87.929f);
        //Quaternion rotation = Quaternion.Euler(rotationVector);
        //print("Quarternion: (" + rotation.x + "," + rotation.y + "," + rotation.z + "," + rotation.w + ")");

        //print("Quarternion: (" + transform.rotation.x + "," + transform.rotation.y + "," + transform.rotation.z + "," + transform.rotation.w + ")");
        
    }

        
}