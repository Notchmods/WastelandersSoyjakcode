 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lookattake : MonoBehaviour
{
    public Transform[] objects;
    public Text Soynumber;
    public int soylentbottles;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Soynumber.text = soylentbottles.ToString();
        RaycastHit Looked;
       if(Physics.Raycast(transform.position,transform.forward,out Looked,50f))
        {
            if (Looked.transform.tag == "Gate")
            {
                objects[0].gameObject.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (soylentbottles >= 7)
                    {
                        objects[8].gameObject.SetActive(true);
                        Time.timeScale = 0;
                        Cursor.visible = true;
                        Cursor.lockState = CursorLockMode.None;
                    }
                    else
                    {
                        objects[3].gameObject.SetActive(false);
                        objects[5].gameObject.SetActive(true);
                        Time.timeScale = 0;
                    }
                }
            }
            else
            {
                objects[0].gameObject.SetActive(false);
            }
            if (Looked.transform.tag == "soy")
            {
                objects[6].gameObject.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Looked.transform.gameObject.SetActive(false);
                    soylentbottles += 1;
                }
            }else
            {
                objects[6].gameObject.SetActive(false);
            }
            if (soylentbottles >= 7)
            {
                objects[4].gameObject.SetActive(false);
                objects[7].gameObject.SetActive(true);
            }else
            {
                objects[7].gameObject.SetActive(false);
            }
        }
    }
}
