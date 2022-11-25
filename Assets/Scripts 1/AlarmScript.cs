using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlarmScript : MonoBehaviour
{
    public int cnt = 0;
    public GameObject talkPanel;
    public GameObject nextbtn;
    public GameObject emergency;
    // Start is called before the first frame update
    void Start()
    {

        talkPanel.SetActive(false);
        //nextbtn.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 5.0f))
        {
            if (hit.collider.gameObject.tag == "PATIENT")
            {
                if (Input.GetKeyDown(KeyCode.F))
                {
                    emergency.SetActive(false);
                    if (cnt == 0)
                    {
                        talkPanel.SetActive(true);
                        Debug.Log(talkPanel.activeSelf);
                        cnt++;
                    }
                    
                    Debug.Log(cnt);

                }
               
            }

        }
    }
}
