using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintClose : MonoBehaviour
{
    public GameObject Hint;
    public GameObject Create;
    public GameObject Choice;
    public GameObject After;
    string NG1 = "äYìñÇÃåÆÇéùÇ¡ÇƒÇ¢Ç‹ÇπÇÒ";
    string NG2 = "Ç±ÇÃåÆÇÕëgÇ›çáÇÌÇπÇÁÇÍÇ»Ç¢ÇÊÇ§Ç≈Ç∑";
    string OK = "éáÇÃåÆÇ™Ç≈Ç´ÇΩ";
    bool red;
    bool blue;
    bool yellow;
    bool green;
    bool purple;
    public GameObject redP;
    public GameObject blueP;
    public GameObject purpleP;
    public TMPro.TMP_Text Text;
    public bool create = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Onclick()
    {
        Hint.SetActive(false);
        Create.SetActive(false);
        Choice.SetActive(false);
        After.SetActive(false);
    }
    public void AfterClose()
    {
        After.SetActive(false);
    }
    public void OnChoiceClick(int a)
    {
        Create.SetActive(false);
        Choice.SetActive(false);
        getbool();
        if (a == 0)
        {
            if (red == true && blue == true)
            {
                create = true;
                After.SetActive(true);
                Text.text = OK;
                
            }
            else
            {
                After.SetActive(true);
                Text.text = NG1;
            }
        }else if (a == 1)
        {
            if (yellow == true && green == true)
            {
                After.SetActive(true);
                Text.text = NG2;
            }
            else
            {
                After.SetActive(true);
                Text.text = NG1;
            }
        }
        
    }
    void getbool()
    {
        PlayerItemControl pic = GetComponent<PlayerItemControl>();
        red = pic.red;
        blue = pic.blue;
        green = pic.green;
        yellow = pic.yellow;
    }
    /*
    public static bool getPurple()
    {
        return create;
    }*/
}
