using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuSaveGameManager : MonoBehaviour
{
    //public Canvas canvas;
    // Start is called before the first frame update
    public GameObject Menu;
    public GameObject Item;
    ArrayList ItemList = new ArrayList()
    {"Empty","Empty","Empty","Empty","Empty" };
    public string ItemName;
    [SerializeField]
    public TMPro.TMP_Text Item1;
    public TMPro.TMP_Text Item2;
    public TMPro.TMP_Text Item3;
    public TMPro.TMP_Text Item4;
    public TMPro.TMP_Text Item5;
    public int ItemCount = 0;
    public GameObject Obj;
    public GameObject ItemPrefab;
    public GameObject Scroll;
    string test="Empty";
    void Start()
    {
        /*  Item1.text = "Empty1";
          Item2.text = "Empty2";
          Item3.text = "Empty";
          Item4.text = "Empty";
          Item5.text = "Empty";*/
        //try
        //{
            test = SaveData.GetString("test");
            Debug.Log(test);
        //}
        //catch//(NullReferenceException e)
        //{
            //Debug.Log(e);
          //  Debug.Log(test);
        //}
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            if(Menu.activeSelf == true|| Item.activeSelf == true)
            {
                Item.SetActive(false);
                Menu.SetActive(false);
            } else if (Menu.activeSelf == false)
            {
                Menu.SetActive(true);
            }
        }
        if(Menu.activeSelf == true)
        {
            Item.SetActive(false);
        }
        foreach (var s in ItemList)
        {
            //Obj = (GameObject)Instantiate(ItemPrefab, this.transform.position, Quaternion.identity);
            //Obj.transform.parent = Scroll.transform;
           // Instantiate(ItemPrefab);
            //Debug.Log(s);
        }
    }
    /*
    void OnTriggerStay2D(Collider2D col)
    {
        //col.gameObject.SetActive(false);
        if (Input.GetKeyDown(KeyCode.N))
        {
            Debug.Log("ê⁄êG2");
            if (col.gameObject.CompareTag("Item"))
            {
                //ItemName = col.gameObject.name;
                // ItemList.Add(ItemName);
                //ItemList[ItemCount] = ItemName;
                //ItemCount++;
                Debug.Log("ê⁄êG3");
                col.gameObject.SetActive(false);
            }
        }
    }/*
    string str;
    public void OnClickItem(int n)
    {
        if (ItemList[n] == "Empty")
        {
            str = "Empty";
        }
        else
        {
            str = "Apple";
        }
        Debug.Log(str);
    }*/
    
}
