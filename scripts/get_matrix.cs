using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class get_matrix : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject rt = GameObject.Find("rentou");

        Matrix4x4 rot = new Matrix4x4();
        Quaternion rotation = Quaternion.Euler(rt.transform.localEulerAngles.x, rt.transform.localEulerAngles.y, rt.transform.localEulerAngles.z);
        rot.SetTRS(new Vector3(0,0,0), rotation, new Vector3(1, 1, 1));
        this.GetComponent<Text>().text = rot.ToString();
    }
}
