using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SaveDateAreaClick : MonoBehaviour
{
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SaveClick(int num)
    {
        GetData(num);
        SaveData.Save();
    }
    void GetData(int num)
    {
        PlayerItemControl pic;
        pic= obj.GetComponent<PlayerItemControl>();

        //SaveData.SetInt("Apple" + num.ToString(), Convert.ToInt32(pic.apple));
        //SaveData.SetInt("Arrow" + num.ToString(), Convert.ToInt32(pic.arrow));
    }
}
