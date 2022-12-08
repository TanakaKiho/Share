using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleButton : MonoBehaviour
{
    public static string Mode;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartClick()
    {
        Mode = "Start";
        SceneManager.LoadScene("Stage1");
    }
    public void LoadClick()
    {
        Mode = "Load";
        try
        {
            SceneManager.LoadScene(SaveData.GetString("ÉVÅ[Éì"));
        }
        catch
        {

        }
        
    }
    public void BackClick()
    {
        SceneManager.LoadScene("Title");
    }

    public static string getMode()
    {
        return Mode;
    }
    public static string changeMode(string str)
    {
        Mode = str;
        return Mode;
    }
}
