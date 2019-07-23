using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using System.Threading;
using System;

public class save_file : MonoBehaviour
{
    //public static GameObject disk = GameObject.Find("Canvas/disk");
    //public static GameObject folder = GameObject.Find("Canvas/folder");
    
    Vector3 pos;
    Quaternion rot;
    Vector3 scale;

    Text text1;
    Text text2;
    GameObject disk;
    GameObject folder;

    Vector3 left;
    Vector3 right;

    float zero = 0.000f;
    //byte[] data;
    string path;

    public float last = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        //GameObject disk = GameObject.Find("Canvas/disk");
        //GameObject folder = GameObject.Find("Canvas/folder");
        //path = disk.GetComponent<Dropdown>().options[disk.GetComponent<Dropdown>().value].text + ":\\" +
        //                 folder.GetComponent<Dropdown>().options[folder.GetComponent<Dropdown>().value].text + "\\";


    }

    // Update is called once per frame
    void Update()
    {
        //GameObject save = GameObject.Find("Canvas/save_info");
        //if (save.GetComponent<Text>().text == "Saved !")
        //{
        //    Invoke("TestFunc",1.0f);
        //}
        //save.GetComponent<Text>().text = "test";
        

        if (Input.GetKey(KeyCode.Space))
        {
            Save();
        }
    }

    public void TestFunc()
    {
        Debug.Log("Test");
    }

    public void Save()
    {

        disk = GameObject.Find("Canvas/disk");
        folder = GameObject.Find("Canvas/folder");
        path = disk.GetComponent<Dropdown>().options[disk.GetComponent<Dropdown>().value].text + ":\\" +
                         folder.GetComponent<Dropdown>().options[folder.GetComponent<Dropdown>().value].text + "\\";

        GameObject Name = GameObject.Find("Canvas/imgName");
        GameObject rentou = GameObject.Find("rentou");
        GameObject info1 = GameObject.Find("Canvas/save_info");
        GameObject count = GameObject.Find("Canvas/count");
        GameObject tog = GameObject.Find("Canvas/click");
        //================================================================================
        GameObject left_front = GameObject.Find("rentou/left/left_c/left_front");
        GameObject left_back = GameObject.Find("rentou/left/left_c/left_back");
        GameObject right_front = GameObject.Find("rentou/right/right_c/right_front");
        GameObject right_back = GameObject.Find("rentou/right/right_c/right_back");

        //GameObject info2 = GameObject.Find("Canvas/save_info");
        //info.SetActive(true);

        text1 = info1.GetComponent<Text>();
        //text2 = info2.GetComponent<Text>();

        string txtfile;
        pos = rentou.transform.position;
        rot = rentou.transform.rotation;
        scale = rentou.transform.localScale;
        
        left = (left_front.transform.position - left_back.transform.position).normalized;
        right = (right_front.transform.position - right_back.transform.position).normalized;


        txtfile = Name.GetComponent<Text>().text;
        
        FileStream fs = new FileStream(path+"info\\"+System.IO.Path.GetFileNameWithoutExtension(txtfile)+".txt", FileMode.Create);

        


        if (tog.GetComponent<Toggle>().isOn)
        {
            byte[] data = System.Text.Encoding.Default.GetBytes(rot.x.ToString("F5") + " " + rot.y.ToString("F5") + " " + rot.z.ToString("F5") + " " + rot.w.ToString("F5") + "\r\n" +
                                                            pos.x.ToString("F3") + " " + pos.y.ToString("F3") + " " + pos.z.ToString("F3") + "\r\n" +
                                                            scale.x.ToString("F3") + " " + scale.y.ToString("F3") + " " + scale.z.ToString("F3") + "\r\n" +
                                                            (-left.x).ToString("F3") + " " + left.y.ToString("F3") + " " + left.z.ToString("F3") + "\r\n" +
                                                            (-right.x).ToString("F3") + " " + right.y.ToString("F3") + " " + right.z.ToString("F3") + "\r\n"
                                                            );
            fs.Write(data, 0, data.Length);

            fs.Flush();
            fs.Close();
        }

        else
        {
            byte[] data = System.Text.Encoding.Default.GetBytes(rot.x.ToString("F5") + " " + rot.y.ToString("F5") + " " + rot.z.ToString("F5") + " " + rot.w.ToString("F5") + "\r\n" +
                                                            pos.x.ToString("F3") + " " + pos.y.ToString("F3") + " " + pos.z.ToString("F3") + "\r\n" +
                                                            scale.x.ToString("F3") + " " + scale.y.ToString("F3") + " " + scale.z.ToString("F3") + "\r\n" +
                                                            zero.ToString("F3") + " " + zero.ToString("F3") + " " + zero.ToString("F3") + "\r\n" +
                                                            zero.ToString("F3") + " " + zero.ToString("F3") + " " + zero.ToString("F3") + "\r\n"
                                                            );

            fs.Write(data, 0, data.Length);

            fs.Flush();
            fs.Close();
        }
       
        
        
      

        

        //DateTime Start = DateTime.Now;
        text1.text = "Saved !";
        //info1.GetComponent<Text>().enabled = true;

        //while ((DateTime.Now.Subtract(Start).TotalMilliseconds) < 500.0f)
        //{
        //    //info.GetComponent<Text>().text = "Saved !";
        //}
        //info1.GetComponent<Text>().enabled = false;


        string logPath = path+"log\\" + "log.txt";
        int imgCount;

        if (File.Exists(logPath))
        {
            

            FileInfo fi = new FileInfo(logPath);
            if (fi.Length == 0)
            {
                FileStream fs1 = new FileStream(path + "log\\" + "log.txt", FileMode.Open);
                byte[] data1 = System.Text.Encoding.Default.GetBytes(Name.GetComponent<Text>().text + "\r\n" +
                                                                count.GetComponent<Text>().text
                                                                );

                fs1.Write(data1, 0, data1.Length);

                fs1.Flush();
                fs1.Close();
                
            }
           

            else
            {
                
                FileStream f = new FileStream(logPath, FileMode.Open);
                StreamReader sr = new StreamReader(f);
                string strLine = sr.ReadLine();
                strLine = sr.ReadLine();
                imgCount = int.Parse(strLine);
                f.Flush();
                f.Close();
                sr.Close();

                if (imgCount < int.Parse(count.GetComponent<Text>().text))
                {
                    FileStream fs2 = new FileStream(path + "log\\" + "log.txt", FileMode.Open);
                    byte[] data2 = System.Text.Encoding.Default.GetBytes(Name.GetComponent<Text>().text + "\r\n" +
                                                                    count.GetComponent<Text>().text
                                                                    );

                    fs2.Write(data2, 0, data2.Length);

                    fs2.Flush();
                    fs2.Close();
                }
                else
                {
                    return;
                }
                
            }
            


            
        }
        else
        {
            StreamWriter sr;
            sr = File.CreateText(logPath);
            sr.Close();
        }
    }
}
