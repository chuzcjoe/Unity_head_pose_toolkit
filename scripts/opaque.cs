using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;


public class opaque : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject img = GameObject.Find("Canvas/Image");
        img.GetComponent<Image>().color = new Color(194.0f, 194.0f, 194.0f, this.GetComponent<Slider>().value);
    }

}