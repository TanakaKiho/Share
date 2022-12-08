using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    /*
    public GameObject player;
    public GameObject allow;
    public GameObject playerPrefab;
    public GameObject allowPrefab;*/
    public static string gameMode;
    public TMPro.TMP_Text Text;
    public GameObject After;


    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 now = rigidBody.position;
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        //Input.GetKey(KeyCode.W)
        if (x > 0)
        {
            //rigidBody.AddForce(transform.right * 2.0f);
            now += new Vector3(0.05f, 0.0f);
            rigidBody.position = now;
        }
        else if (x < 0)
        {
            //rigidBody.AddForce(-transform.right * 2.0f);
            now += new Vector3(-0.05f, 0.0f);
            rigidBody.position = now;
        }
        if(y > 0)
        {
            rigidBody.AddForce(transform.up * 2.0f);
            now += new Vector3(0.0f, 0.05f);
            rigidBody.position = now;
        }
        else if (y < 0)
        {
            rigidBody.AddForce(-transform.up * 2.0f);
            now += new Vector3(0.0f, -0.05f);
            rigidBody.position = now;
        }
        //pic = GetComponent<PlayerItemControl>();
    }
    /*
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
            //other.gameObject.SetActive(false);
            //Destroy(allow);
            //Destroy(player);

            //allow = (GameObject)Instantiate(allowPrefab);
            //player = (GameObject)Instantiate(playerPrefab);
    /*
            Scene activeScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(activeScene.name);
        }
    }*/
    /*
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Item"))
        {
            Debug.Log("ê⁄êGÇP");
            other.gameObject.SetActive(false);/*
            if (Input.GetKeyDown(KeyCode.N))                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         
            {
                Debug.Log("ê⁄êG3");
                other.gameObject.SetActive(false);
            }
        }
    }*/
   

    void OnCollisionStay(Collision collision)
    {
        Debug.Log("ê⁄êGÇQ");
    }
    /*
    void OnItemPickUp(InputValue input)
    {
        this.OnTriggerEnter2D();
    }*/

    //É^ÉO"enemy"Ç…ê⁄êGÇµÇΩÇÁã≠êßÉäÉZÉbÉg
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == ("enemy")){
           // Scene activeScene = SceneManager.GetActiveScene();
           // SceneManager.LoadScene(activeScene.name);
            SceneManager.LoadScene("GameOver");
        }
    }
    void OnTriggerStay2D(Collider2D col)
    {
        //PlayerItemControl pic= GetComponent<PlayerItemControl>();
        //pic = obj.GetComponent<PlayerItemControl>();
        if (Input.GetKeyDown(KeyCode.N))
        {
            if (col.gameObject.CompareTag("next"))
            {
                gameMode = "Change";
                //Mode=TitleButton.changeMode("Change");
                setData("Change");
                string scName = SceneManager.GetActiveScene().name;
                if (scName == "Stage1")
                {
                    SceneManager.LoadScene("Stage2");
                }else if (scName == "Stage2")
                {
                    SceneManager.LoadScene("Stage3");
                }else if (scName == "Stage3")
                {
                    HintClose hc = GetComponent<HintClose>();
                    bool clear = hc.create;
                    if (clear == true)
                    {
                        SceneManager.LoadScene("Clear");
                    }
                    else
                    {
                        After.SetActive(true);
                        Text.text = "åÆÇ™Ç†ÇËÇ‹ÇπÇÒ";
                    }
                    
                }
            }else if (col.gameObject.CompareTag("back"))
            {
                gameMode = "Change";
                //Mode = "Change";
                setData("Change");
                string scName = SceneManager.GetActiveScene().name;
                if (scName == "Stage3")
                {
                    SceneManager.LoadScene("Stage2");
                }
                else if (scName == "Stage2")
                {
                    SceneManager.LoadScene("Stage1");
                }
            }
        }
    }
    void setData(string str)
    {
        PlayerItemControl pic = GetComponent<PlayerItemControl>();
        SaveData.SetInt("ê‘Ç¢åÆ" + str, Convert.ToInt32(pic.red));
        SaveData.SetInt("ê¬Ç¢åÆ" + str, Convert.ToInt32(pic.blue));
        SaveData.SetInt("â©êFÇ¢åÆ" + str, Convert.ToInt32(pic.yellow));
        SaveData.SetInt("óŒÇÃåÆ" + str, Convert.ToInt32(pic.green));
        SaveData.SetInt("éáÇÃåÆ" + str, Convert.ToInt32(pic.purple));
        SaveData.Save();
    }
    public static string getMode()
    {
        return gameMode;
    }
    
}
