using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Commandcenter : MonoBehaviour
{
    public bool Game;
    public Transform[] Objects;
    int lightson;
    // Start is called before the first frame update
    void Start()
    {
        if (Game == true)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0f)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        if(Input.GetKeyDown(KeyCode.F))
        {
            if(lightson == 1)
            {
                Objects[2].gameObject.SetActive(true);
                lightson = 0;
            }
            else
            {
                Objects[2].gameObject.SetActive(false);
                lightson = 1;
            }
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            Time.timeScale = 0;
            Objects[3].gameObject.SetActive(true);
           
        }
    }
    public void Startgame()
    {
        Game = false;
        Time.timeScale = 1;
    }

    public void Pancameratosoyjack()
    {
        Objects[0].gameObject.SetActive(true);
        Objects[1].gameObject.SetActive(false);
    }

    public void Panbacktoplayer()
    {
        Objects[0].gameObject.SetActive(false);
        Objects[1].gameObject.SetActive(true);
    }

    public void Find7soylent()
    {
         Game = false;
        Time.timeScale = 1;
        Objects[4].gameObject.SetActive(false);
        Objects[5].gameObject.SetActive(true);
    }
    
    public void Opengates()
    {
       Objects[6].transform.GetComponent<Animator>().enabled = true;
        Objects[7].transform.GetComponent<Animator>().enabled = true;
        Objects[8].transform.GetComponent<Lookattake>().soylentbottles -= 7;
        Time.timeScale = 1;
    }
}
