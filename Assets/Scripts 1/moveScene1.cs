using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class moveScene1 : MonoBehaviour
{
    public GameObject talkPanel;
    public int cnt = 0;

    void Start()
    {
        talkPanel.SetActive(false);
    }

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 10.0f))
        {
            if (hit.collider.gameObject.tag == "WOMAN")
            {
                if (Input.GetKeyDown(KeyCode.F))
                {
                    cnt++;
                    if (cnt == 1)
                    {
                        Debug.Log("show2");
                        talkPanel.SetActive(true);
                        
                        cnt++;
                        Debug.Log("girl"+ cnt);
                    }


                    /*SceneManager.LoadScene(2);
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;*/

                }
            }

        }
    }
}
