using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetData : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnclickReset()
    {
        SaveData.Clear();
        SaveData.Save();
        Debug.Log("çÌèú");
    }
}
