using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;


public class resize : MonoBehaviour
{
    double e = 1.1;
    double s = 0.9;

    float w;
    float h;

    Vector2 size;

    // Start is called before the first frame update
    void Start()
    {

    }
 
    // Update is called once per frame
    void Update()
    {
        //if (Input.GetAxis("Mouse ScrollWheel") < 0)
        //{
        //    Expand();
        //}
        //
        //if (Input.GetAxis("Mouse ScrollWheel") > 0)
        //{
        //    shrink();
        //}
    }


    public void Expand()
    {
        GameObject img = GameObject.Find("Canvas/Image");
        w = img.GetComponent<RectTransform>().sizeDelta.x;
        h = img.GetComponent<RectTransform>().sizeDelta.y;
        size = new Vector2(w * 1.2f, h * 1.2f);
        img.GetComponent<RectTransform>().sizeDelta = size;
    }

    public void shrink()
    {
        GameObject img = GameObject.Find("Canvas/Image");
        w = img.GetComponent<RectTransform>().sizeDelta.x;
        h = img.GetComponent<RectTransform>().sizeDelta.y;
        size = new Vector2(w * 0.9f, h*0.9f);
        img.GetComponent<RectTransform>().sizeDelta = size;
    }


}
