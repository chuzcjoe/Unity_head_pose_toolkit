using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;


public class down : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    float MoveSpeed = 20.0f;
    // Update is called once per frame
    void Update()
    {
        
    }


    public void MoveDown()
    {
        GameObject img = GameObject.Find("Canvas/Image");
        img.GetComponent<RectTransform>().anchoredPosition = new Vector2(img.GetComponent<RectTransform>().anchoredPosition.x, img.GetComponent<RectTransform>().anchoredPosition.y - MoveSpeed);
    }
}
