using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerItemControl : MonoBehaviour
{
    [SerializeField]
    private ItemDataBase itemDataBase;

    private Dictionary<Item, int> numOfItem = new Dictionary<Item, int>();
    string ItemName;
    //public GameObject ApplePanel;
    //public GameObject ArrowPanel;
    //public bool apple;
    //public bool arrow;
    public GameObject Hint;
    public GameObject Create;
    public GameObject Choice;
    public GameObject redP;
    public GameObject blueP;
    public GameObject greenP;
    public GameObject yellowP;
    public GameObject purpleP;
    public bool blue;
    public bool green;
    public bool red;
    public bool yellow;
    public bool purple;
    public GameObject redI;
    public GameObject blueI;
    public GameObject greenI;
    public GameObject yellowI;
    string TitleMode = TitleButton.getMode();
    string gameMode = PlayerControl.getMode();
    bool create = false;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < itemDataBase.GetItemLists().Count; i++)
        {
            //　アイテム数を適当に設定
            numOfItem.Add(itemDataBase.GetItemLists()[i], i);
            //　確認の為データ出力
           // Debug.Log(itemDataBase.GetItemLists()[i].GetItemName() + ": " + itemDataBase.GetItemLists()[i].GetInformation());
        }

        //apple = Convert.ToBoolean(SaveData.GetInt("Apple"));
        //arrow = Convert.ToBoolean(SaveData.GetInt("Arrow"));

        if (gameMode == "Change")
        {
            Loading("Change");
        }
        else if (TitleMode == "Start")
        {
            red = false;
            blue = false;
            yellow = false;
            purple = false;
            green = false;
        }
        else if (TitleMode == "Load")
        {
            Loading("SAVE");
        }
        Debug.Log(TitleMode);
        Debug.Log(gameMode);
    }

    // Update is called once per frame
    void Update()
    {
        HintClose hc = GetComponent<HintClose>();
        create = hc.create;
        //ApplePanel.gameObject.SetActive(apple);
        //ArrowPanel.gameObject.SetActive(arrow);
        if (create == true)
        {
            redP.gameObject.SetActive(false);
            blueP.gameObject.SetActive(false);
            purpleP.gameObject.SetActive(true);
        }
        else
        {
            redP.gameObject.SetActive(red);
            blueP.gameObject.SetActive(blue);
            greenP.gameObject.SetActive(green);
            yellowP.gameObject.SetActive(yellow);
            purpleP.gameObject.SetActive(purple);
        }
        if (red == true)
        {
            redI.gameObject.SetActive(false);
        }
        if (blue == true)
        {
            blueI.gameObject.SetActive(false);
        }
        if (green == true)
        {
            greenI.gameObject.SetActive(false);
        }
        if (yellow == true)
        {
            yellowI.gameObject.SetActive(false);
        }
        
    }
    void OnTriggerStay2D(Collider2D col)
    {
        //col.gameObject.SetActive(false);
        if (Input.GetKeyDown(KeyCode.N))
        {
            Debug.Log("接触2");
            if (col.gameObject.CompareTag("Item"))
            {
                ItemName = col.gameObject.name;
                // ItemList.Add(ItemName);
                //ItemList[ItemCount] = ItemName;
                //ItemCount++;
                //ItemName = ItemManager.GetItem(ItemName);
                Debug.Log("接触3");
                //Debug.Log(GetItem(ItemName).GetInformation());
                //apple = true;
                boolswitch(ItemName);
              //  SaveData.Save();
                col.gameObject.SetActive(false);
            }
            if (col.gameObject.CompareTag("Hint"))
            {
                Hint.SetActive(true);
            }
            if (col.gameObject.CompareTag("Create"))
            {
                Create.SetActive(true);
                Choice.SetActive(true);
            }
        }
    }
    public Item GetItem(string searchName)
    {
        return itemDataBase.GetItemLists().Find(itemName => itemName.GetItemName() == searchName);
    }
    void boolswitch(string item)
    {
        switch (item)
        {
           /* case "Apple":
                apple = true;
              //  SaveData.SetInt("Apple", Convert.ToInt32(apple));
                break;
            case "Arrow":
                arrow = true;
              //  SaveData.SetInt("Arrow", Convert.ToInt32(arrow));
                break;*/
            case "Blue":
                blue = true;
                break;
            case "Red":
                red = true;
                break;
            case "Green":
                green = true;
                break;
            case "Yellow":
                yellow = true;
                break;
            case "Purple":
                purple = true;
                break;
        }
    }
    void Loading(string str)
    {
        red = Convert.ToBoolean(SaveData.GetInt("赤い鍵"+str));
        blue = Convert.ToBoolean(SaveData.GetInt("青い鍵" + str));
        yellow = Convert.ToBoolean(SaveData.GetInt("黄色の鍵" + str));
        purple = Convert.ToBoolean(SaveData.GetInt("紫の鍵" + str));
        green = Convert.ToBoolean(SaveData.GetInt("緑の鍵" + str));
    }

}
