using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class moveScene2 : MonoBehaviour
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
            if (hit.collider.gameObject.tag == "MAN")
            {
                if (Input.GetKeyDown(KeyCode.F))
                {
                    cnt++;
                    if (cnt == 1)
                    {
                        Debug.Log("show3");
                        talkPanel.SetActive(true);
                        cnt++;
                        Debug.Log("boy" + cnt);
                    }
                    //SceneManager.LoadScene(3);

                }
            }

        }
    }
}
