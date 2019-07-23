using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class show_img : MonoBehaviour
{
    //List<Texture2D> loadTexture = new List<Texture2D>();
    List<Sprite> loadsprite = new List<Sprite>();
    //public static GameObject disk = GameObject.Find("Canvas/disk");
    //public static GameObject folder = GameObject.Find("Canvas/folder");
    //static string path = disk.GetComponent<Dropdown>().options[disk.GetComponent<Dropdown>().value].text + ":\\" +
    //                    folder.GetComponent<Dropdown>().options[folder.GetComponent<Dropdown>().value].text + "\\";

    //List<string> filePaths = new List<string>();
    //filePaths = GetImagePath();

    public static bool flag = true;
    Image myimg;
    static string s;

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

    string path;
    GameObject disk;
    GameObject folder;

    static bool first_time = true;

    public static int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        //GameObject disk = GameObject.Find("Canvas/disk");
        //GameObject folder = GameObject.Find("Canvas/folder");
        //path = disk.GetComponent<Dropdown>().options[disk.GetComponent<Dropdown>().value].text + ":\\" +
        //                 folder.GetComponent<Dropdown>().options[folder.GetComponent<Dropdown>().value].text + "\\";
        //
        //string logPath = path +
        //                 "log\\" + "log.txt";
        ////string imgPath;
        //int imgCount;
        //GameObject rentou = GameObject.Find("rentou");
        //GameObject sp = GameObject.Find("Sphere");
        //GameObject img = GameObject.Find("Canvas/Image");
        //GameObject Name = GameObject.Find("Canvas/imgName");
        //GameObject count = GameObject.Find("Canvas/count");
        //GameObject img1 = GameObject.Find("Canvas/Image");

       // if (File.Exists(logPath))
       // {
       //     FileInfo fi = new FileInfo(logPath);
       //     if (fi.Length == 0)
       //     {
       //         //rentou.transform.position = new Vector3(0.107f, 1.812f, -0.16f);
       //         ////rentou.transform.rotation = new Quaternion(0.0f, 0.0f, 0.0f, 1.0f);
       //         //sp.transform.eulerAngles = new Vector3(0f, 0f, 0f);
       //         //rentou.transform.eulerAngles = new Vector3(-0f, 0f, 0f);
       //         //rentou.transform.localScale = new Vector3(0.020f, 0.020f, 0.020f);
       //         return;
       //     }
       //     else
       //     {
       //         FileStream f = new FileStream(logPath, FileMode.Open);
       //         StreamReader sr = new StreamReader(f);
       //         string strLine = sr.ReadLine();
       //         //imgPath = strLine;
       //
       //
       //         strLine = sr.ReadLine();
       //         imgCount = int.Parse(strLine);
       //
       //         sr.Close();
       //
       //         i = imgCount - 1;
       //         //s = LoadTexture2Sprite(i);
       //         //Name.GetComponent<Text>().text = s;
       //         //count.GetComponent<Text>().text = imgCount.ToString();
       //         //
       //         //myimg = img1.GetComponent<Image>();
       //         //
       //         //myimg.sprite = loadsprite[0];
       //         //
       //         //FileStream f1 = new FileStream("D:\\info\\" + System.IO.Path.GetFileNameWithoutExtension(imgPath) + ".txt", FileMode.Open);
       //         //StreamReader sr1 = new StreamReader(f1);
       //         //string strLine1 = sr1.ReadLine();
       //         //
       //         //string[] split_item1 = strLine1.Split();
       //         //old_rotate_x = float.Parse(split_item1[0]);
       //         //old_rotate_y = float.Parse(split_item1[1]);
       //         //old_rotate_z = float.Parse(split_item1[2]);
       //         //old_rotate_w = float.Parse(split_item1[3]);
       //         //
       //         //
       //         //
       //         //sr1.Close();
       //         //
       //         //
       //         //rentou.transform.rotation = new Quaternion(old_rotate_x, old_rotate_y, old_rotate_z, old_rotate_w);
       //         //sp.transform.rotation = new Quaternion(old_rotate_x, old_rotate_y, old_rotate_z, old_rotate_w);
       //         
       //     }
       //
       //
       //
       //
       // }

    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (Input.GetKeyDown(KeyCode.Comma))
        {
            Back();
            
        }

        if (Input.GetKeyDown(KeyCode.Period))
        {
            OnClick();
            //print("Peroid havs been pressed!");
            
        }
        
    }

    //void FixedUpdate()
    //{
       //GameObject Name = GameObject.Find("Canvas/imgName");
       //GameObject rentou = GameObject.Find("rentou");
       //string jpgName;
       //
       //jpgName = Name.GetComponent<Text>().text;
       //string filePath = "E:\\info\\"+ System.IO.Path.GetFileNameWithoutExtension(jpgName) + ".txt";
       //
       //if (File.Exists(filePath))
       //{
       //    FileStream f = new FileStream("E:\\info\\" + System.IO.Path.GetFileNameWithoutExtension(jpgName) + ".txt", FileMode.Open);
       //    StreamReader sr = new StreamReader(f);
       //    string strLine = sr.ReadLine();
       //
       //    string[] split_item = strLine.Split();
       //    old_rotate_x = float.Parse(split_item[0]);
       //    old_rotate_y = float.Parse(split_item[1]);
       //    old_rotate_z = float.Parse(split_item[2]);
       //    old_rotate_w = float.Parse(split_item[3]);
       //
       //    strLine = sr.ReadLine();
       //    split_item = strLine.Split();
       //    old_pos_x = float.Parse(split_item[0]);
       //    old_pos_y = float.Parse(split_item[1]);
       //    old_pos_z = float.Parse(split_item[2]);
       //
       //    strLine = sr.ReadLine();
       //    split_item = strLine.Split();
       //    old_scale_x = float.Parse(split_item[0]);
       //    old_scale_y = float.Parse(split_item[1]);
       //    old_scale_z = float.Parse(split_item[2]);
       //
       //    sr.Close();
       //
       //    rentou.transform.position = new Vector3(old_pos_x, old_pos_y, old_pos_z);
       //    rentou.transform.rotation = new Quaternion(old_rotate_x, old_rotate_y, old_rotate_z, old_rotate_w);
       //    rentou.transform.localScale = new Vector3(old_scale_x, old_scale_x, old_scale_x);
       //}

        //else
        //{
        //    rentou.transform.position = new Vector3(old_pos_x, old_pos_y, old_pos_z);
        //    rentou.transform.rotation = new Quaternion(old_rotate_x, old_rotate_y, old_rotate_z, old_rotate_w);
        //    rentou.transform.localScale = new Vector3(old_scale_x, old_scale_x, old_scale_x);
        //}


    
   // }


    public void OnClick()
    {
        disk = GameObject.Find("Canvas/disk");
        folder = GameObject.Find("Canvas/folder");
        
        path = disk.GetComponent<Dropdown>().options[disk.GetComponent<Dropdown>().value].text + ":\\" +
                         folder.GetComponent<Dropdown>().options[folder.GetComponent<Dropdown>().value].text + "\\";

        GameObject img = GameObject.Find("Canvas/Image");
        GameObject Name = GameObject.Find("Canvas/imgName");
        GameObject count = GameObject.Find("Canvas/count");

        if (first_time)
        {
            i = int.Parse(count.GetComponent<Text>().text) - 1;
            first_time = false;
        }

        if (i == 0 && flag)
        {
            s = LoadTexture2Sprite(0);
            flag = false;
            Name.GetComponent<Text>().text = s;
            count.GetComponent<Text>().text = "1";
        }
        else
        {
            s = LoadTexture2Sprite(i + 1);
            Name.GetComponent<Text>().text = s;
            i = i + 1;
            count.GetComponent<Text>().text = (i+1).ToString();
        }
        
        myimg = img.GetComponent<Image>();
        //for (i; i < loadsprite.Count; i++)
        myimg.sprite = loadsprite[0];
        //Name.GetComponent<Text>().text = ;


        //GameObject Name = GameObject.Find("Canvas/imgName");
        GameObject rentou = GameObject.Find("rentou");
        GameObject sp = GameObject.Find("Sphere");
        string jpgName;

        jpgName = Name.GetComponent<Text>().text;
        string filePath = path + "info\\" + System.IO.Path.GetFileNameWithoutExtension(jpgName) + ".txt";

        if (File.Exists(filePath))
        {
            FileStream f = new FileStream(path + "info\\" + System.IO.Path.GetFileNameWithoutExtension(jpgName) + ".txt", FileMode.Open);
            StreamReader sr = new StreamReader(f);
            string strLine = sr.ReadLine();

            string[] split_item = strLine.Split();
            old_rotate_x = float.Parse(split_item[0]);
            old_rotate_y = float.Parse(split_item[1]);
            old_rotate_z = float.Parse(split_item[2]);
            old_rotate_w = float.Parse(split_item[3]);

            //strLine = sr.ReadLine();
            //split_item = strLine.Split();
            //old_pos_x = float.Parse(split_item[0]);
            //old_pos_y = float.Parse(split_item[1]);
            //old_pos_z = float.Parse(split_item[2]);
            //
            //strLine = sr.ReadLine();
            //split_item = strLine.Split();
            //old_scale_x = float.Parse(split_item[0]);
            //old_scale_y = float.Parse(split_item[1]);
            //old_scale_z = float.Parse(split_item[2]);

            sr.Close();

           //rentou.transform.position = new Vector3(old_pos_x, old_pos_y, old_pos_z);
           rentou.transform.rotation = new Quaternion(old_rotate_x, old_rotate_y, old_rotate_z, old_rotate_w);
           sp.transform.rotation = new Quaternion(old_rotate_x, old_rotate_y, old_rotate_z, old_rotate_w);
            //rentou.transform.localScale = new Vector3(old_scale_x, old_scale_x, old_scale_x);
        }

        else
        {
            rentou.transform.position = new Vector3(0.107f, 1.812f, -0.16f);
            //rentou.transform.rotation = new Quaternion(0.0f, 0.0f, 0.0f, 1.0f);
            sp.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            rentou.transform.eulerAngles = new Vector3(-0f, 0f, 0f);
            rentou.transform.localScale = new Vector3(0.020f, 0.020f, 0.020f);
        }


        

    }

    public void Back()
    {
        GameObject img = GameObject.Find("Canvas/Image");
        GameObject Name = GameObject.Find("Canvas/imgName");
        GameObject count = GameObject.Find("Canvas/count");
        disk = GameObject.Find("Canvas/disk");
        folder = GameObject.Find("Canvas/folder");

        path = disk.GetComponent<Dropdown>().options[disk.GetComponent<Dropdown>().value].text + ":\\" +
                         folder.GetComponent<Dropdown>().options[folder.GetComponent<Dropdown>().value].text + "\\";

        s = LoadTexture2Sprite(i-1);
        Name.GetComponent<Text>().text = s;
        myimg = img.GetComponent<Image>();
        //for (i; i < loadsprite.Count; i++)
        myimg.sprite = loadsprite[0];
        count.GetComponent<Text>().text = i.ToString();
        i = i - 1;


        //GameObject Name = GameObject.Find("Canvas/imgName");
        GameObject rentou = GameObject.Find("rentou");
        GameObject sp = GameObject.Find("Sphere");
        string jpgName;

        jpgName = Name.GetComponent<Text>().text;
        string filePath = path+"info\\" + System.IO.Path.GetFileNameWithoutExtension(jpgName) + ".txt";

        if (File.Exists(filePath))
        {
            FileStream f = new FileStream(path+"info\\" + System.IO.Path.GetFileNameWithoutExtension(jpgName) + ".txt", FileMode.Open);
            StreamReader sr = new StreamReader(f);
            string strLine = sr.ReadLine();

            string[] split_item = strLine.Split();
            old_rotate_x = float.Parse(split_item[0]);
            old_rotate_y = float.Parse(split_item[1]);
            old_rotate_z = float.Parse(split_item[2]);
            old_rotate_w = float.Parse(split_item[3]);

            //strLine = sr.ReadLine();
            //split_item = strLine.Split();
            //old_pos_x = float.Parse(split_item[0]);
            //old_pos_y = float.Parse(split_item[1]);
            //old_pos_z = float.Parse(split_item[2]);
            //
            //strLine = sr.ReadLine();
            //split_item = strLine.Split();
            //old_scale_x = float.Parse(split_item[0]);
            //old_scale_y = float.Parse(split_item[1]);
            //old_scale_z = float.Parse(split_item[2]);

            sr.Close();

            //rentou.transform.position = new Vector3(old_pos_x, old_pos_y, old_pos_z);
            rentou.transform.rotation = new Quaternion(old_rotate_x, old_rotate_y, old_rotate_z, old_rotate_w);
            sp.transform.rotation = new Quaternion(old_rotate_x, old_rotate_y, old_rotate_z, old_rotate_w);
            //rentou.transform.localScale = new Vector3(old_scale_x, old_scale_x, old_scale_x);
        }

        else
        {
            rentou.transform.position = new Vector3(0.107f, 1.812f, -0.16f);
            //rentou.transform.rotation = new Quaternion(0.0f, 0.0f, 0.0f, 1.0f);
            rentou.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            sp.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            rentou.transform.localScale = new Vector3(0.020f, 0.020f, 0.020f);
            
        }

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
