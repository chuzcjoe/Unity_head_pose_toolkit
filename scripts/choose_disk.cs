using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using System.Threading;
using System;

public class choose_disk : MonoBehaviour
{

    List<Sprite> loadsprite = new List<Sprite>();

    float old_pos_x = 0.107f;
    float old_pos_y = 1.812f;
    float old_pos_z = -0.16f;

    float old_rotate_x = 0.0f;
    float old_rotate_y = 0.0f;
    float old_rotate_z = 0.0f;
    float old_rotate_w = 1.0f;

    float old_scale_x = 0.02f;
    float old_scale_y = 0.02f;
    float old_scale_z = 0.02f;

    public static int ii = 0;
    static string ss;
    Image myimg2;
    string logPath;
    string path;
    // Start is called before the first frame update
    void Start()
    {
       
    }


    public void Confirm()
    {
        GameObject disk = GameObject.Find("Canvas/disk");
        GameObject folder = GameObject.Find("Canvas/folder");
        path = disk.GetComponent<Dropdown>().options[disk.GetComponent<Dropdown>().value].text + ":\\" +
                         folder.GetComponent<Dropdown>().options[folder.GetComponent<Dropdown>().value].text + "\\";

        logPath = disk.GetComponent<Dropdown>().options[disk.GetComponent<Dropdown>().value].text + ":\\" +
                         folder.GetComponent<Dropdown>().options[folder.GetComponent<Dropdown>().value].text + "\\" +
                         "log\\" + "log.txt";
        string imgPath;
        int imgCount;
        GameObject rentou = GameObject.Find("rentou");
        GameObject sp = GameObject.Find("Sphere");
        GameObject img = GameObject.Find("Canvas/Image");
        GameObject Name = GameObject.Find("Canvas/imgName");
        GameObject count = GameObject.Find("Canvas/count");
        GameObject img1 = GameObject.Find("Canvas/Image");

        if (File.Exists(logPath))
        {
            FileInfo fi = new FileInfo(logPath);
            if (fi.Length == 0)
            {
                rentou.transform.position = new Vector3(0.107f, 1.812f, -0.16f);
                //rentou.transform.rotation = new Quaternion(0.0f, 0.0f, 0.0f, 1.0f);
                sp.transform.eulerAngles = new Vector3(0f, 0f, 0f);
                rentou.transform.eulerAngles = new Vector3(-0f, 0f, 0f);
                rentou.transform.localScale = new Vector3(0.020f, 0.020f, 0.020f);
            }
            else
            {
                FileStream f = new FileStream(logPath, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(f);
                string strLine = sr.ReadLine();
                imgPath = strLine;


                strLine = sr.ReadLine();
                imgCount = int.Parse(strLine);

                f.Flush();
                f.Close();
                sr.Close();

                ii = imgCount - 1;
                ss = LoadTexture2Sprite(ii);
                Name.GetComponent<Text>().text = ss;
                count.GetComponent<Text>().text = imgCount.ToString();

                myimg2 = img1.GetComponent<Image>();

                myimg2.sprite = loadsprite[0];

                FileStream f1 = new FileStream(path + "info\\" + System.IO.Path.GetFileNameWithoutExtension(imgPath) + ".txt", FileMode.Open);
                StreamReader sr1 = new StreamReader(f1);
                string strLine1 = sr1.ReadLine();

                string[] split_item1 = strLine1.Split();
                old_rotate_x = float.Parse(split_item1[0]);
                old_rotate_y = float.Parse(split_item1[1]);
                old_rotate_z = float.Parse(split_item1[2]);
                old_rotate_w = float.Parse(split_item1[3]);


                f1.Close();
                sr1.Close();


                rentou.transform.rotation = new Quaternion(old_rotate_x, old_rotate_y, old_rotate_z, old_rotate_w);
                sp.transform.rotation = new Quaternion(old_rotate_x, old_rotate_y, old_rotate_z, old_rotate_w);

            }




        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }


    public static byte[] getImageByte(string imagePath)
    {

        FileStream files = new FileStream(imagePath, FileMode.Open);

        byte[] imgByte = new byte[files.Length];

        files.Read(imgByte, 0, imgByte.Length);

        files.Close();

        return imgByte;
    }


    public List<string> GetImagePath()
    {
        List<string> filePaths = new List<string>();
        string imgtype = "*.JPG|*.PNG";
        string[] ImageType = imgtype.Split('|');
        for (int i = 0; i < ImageType.Length; i++)
        {


            string[] dirs = Directory.GetFiles(path + @"/bg_imgs", ImageType[i]);

            for (int j = 0; j < dirs.Length; j++)
            {
                filePaths.Add(dirs[j]);
                //Debug.Log("img_path:     " + dirs[j]);
            }
            //Debug.Log("In total" + dirs.Length + "image(s)");
        }

        return filePaths;
    }



    // Load one image at a time when the function is called.
    public string LoadTexture2Sprite(int i)
    {

        //loadTexture.Clear();
        loadsprite.Clear();

        string filename;

        List<string> filePaths = new List<string>();


        filePaths = GetImagePath();

        //for (int i = 0; i < filePaths.Count; i++)
        //{
        Texture2D t2d = new Texture2D(500, 500);

        t2d.LoadImage(getImageByte(filePaths[i]));

        //loadTexture.Add(t2d);

        Sprite sprite = Sprite.Create(t2d, new Rect(0, 0, t2d.width, t2d.height), Vector2.zero);

        loadsprite.Add(sprite);

        t2d = null;
        sprite = null;

        filename = filePaths[i];
        filePaths.Clear();

        return filename;



        //}
    }
}
