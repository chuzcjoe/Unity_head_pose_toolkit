using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coor_rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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

        if (Input.GetKey(KeyCode.R))
        {
            //向右转
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
