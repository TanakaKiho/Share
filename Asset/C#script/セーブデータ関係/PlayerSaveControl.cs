using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class PlayerSaveControl : MonoBehaviour
{
    public TMPro.TMP_Text Text;
    public GameObject After;
    //public GameObject obj;
    //PlayerItemControl pic;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerStay2D(Collider2D col)
    {
        //col.gameObject.SetActive(false);
        if (Input.GetKeyDown(KeyCode.N))
        {
            if (col.gameObject.CompareTag("Save"))
            {/*
                SaveData.SetString("test", "OK");
                SaveData.Save();
                col.gameObject.SetActive(false);*/
                
                
                setData("SAVE");
                SaveData.Save();
                After.SetActive(true);
                Text.text = "セーブしました";
                Debug.Log("セーブ");
            }
        }
        void setData(string str)
        {
           // PlayerItemControl pic;
            PlayerItemControl pic = GetComponent<PlayerItemControl>();
            SaveData.SetInt("赤い鍵"+str, Convert.ToInt32(pic.red));
            SaveData.SetInt("青い鍵"+str, Convert.ToInt32(pic.blue));
            SaveData.SetInt("黄色い鍵"+str, Convert.ToInt32(pic.yellow));
            SaveData.SetInt("緑の鍵"+str, Convert.ToInt32(pic.green));
            SaveData.SetInt("紫の鍵"+str, Convert.ToInt32(pic.purple));
            SaveData.SetString("シーン", SceneManager.GetActiveScene().name);
        }
    }
}
