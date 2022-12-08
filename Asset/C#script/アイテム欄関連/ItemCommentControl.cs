using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCommentControl : MonoBehaviour
{
    public GameObject Item;
    public GameObject Comment;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Item.activeSelf == false)
        {
            Comment.SetActive(false);
        }
    }
}
