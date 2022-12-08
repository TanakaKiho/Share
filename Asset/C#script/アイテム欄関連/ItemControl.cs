using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemControl : MonoBehaviour
{
    public GameObject Item;
    public GameObject Menu;
    public void OnclickButton()
    {
        if(Item.activeSelf == true)
        {
            Item.SetActive(false);
            Menu.SetActive(true);
            
        }else if (Item.activeSelf == false)
        {
            Menu.SetActive(false);
            Item.SetActive(true);
        }
    }
}
