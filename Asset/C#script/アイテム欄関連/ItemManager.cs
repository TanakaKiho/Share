
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{

	//　アイテムデータベース
	[SerializeField]
	private ItemDataBase itemDataBase;
	//　アイテム数管理
	private Dictionary<Item, int> numOfItem = new Dictionary<Item, int>();

	//public GameObject ItemText;
	// Use this for initialization
	void Start()
	{

		for (int i = 0; i < itemDataBase.GetItemLists().Count; i++)
		{
			//　アイテム数を適当に設定
			numOfItem.Add(itemDataBase.GetItemLists()[i], i);
			//　確認の為データ出力
			Debug.Log(itemDataBase.GetItemLists()[i].GetItemName() + ": " + itemDataBase.GetItemLists()[i].GetInformation());
		}

		Debug.Log(GetItem("Apple").GetInformation());
		Debug.Log(numOfItem[GetItem("矢")]);
	}

	//　名前でアイテムを取得
	public Item GetItem(string searchName)
	{
		return itemDataBase.GetItemLists().Find(itemName => itemName.GetItemName() == searchName);
	}
	/*
	public void OnClick()
	{
		ItemText.gameObject.SetActive(true);
	}*/
}
