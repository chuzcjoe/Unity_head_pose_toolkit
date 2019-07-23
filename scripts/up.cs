using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class up : MonoBehaviour
{

    float MoveSpeed = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void MoveUp()
    {
        GameObject img = GameObject.Find("Canvas/Image");
        img.GetComponent<RectTransform>().anchoredPosition = new Vector2(img.GetComponent<RectTransform>().anchoredPosition.x, img.GetComponent<RectTransform>().anchoredPosition.y+MoveSpeed);
    }
}
