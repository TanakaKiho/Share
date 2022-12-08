using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemButton : MonoBehaviour
{
    public TMPro.TMP_Text Text;
    //public GameObject ItemText;
    [SerializeField]
    private ItemDataBase itemDataBase;
    public TMPro.TMP_Text Item;

    private Dictionary<Item, int> numOfItem = new Dictionary<Item, int>();
    string text;
    public GameObject ItemText;
    // Start is called before the first frame update
    void Start()
    {
        text=GetItem(Text.text).GetInformation();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public Item GetItem(string searchName)
    {
        return itemDataBase.GetItemLists().Find(itemName => itemName.GetItemName() == searchName);
    }
    public void OnClick()
    {
        ItemText.gameObject.SetActive(true);
        Item.text = text;
    }
}
