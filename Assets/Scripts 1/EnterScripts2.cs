using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterScripts2 : MonoBehaviour
{
    public GameObject talkPanel;
    public GameObject talkPanel2;
    public GameObject talkPanel3;
    public GameObject talkPanel4;
    public GameObject nextbtn;
    public int SceneCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        nextbtn.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("TT_demo_male_A").GetComponent<AlarmScript>().cnt == 2)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                talkPanel2.SetActive(false);
                GameObject.Find("TT_demo_male_A").GetComponent<AlarmScript>().cnt++;
                //GameObject.Find("TT_demo_male_A").GetComponent<AlarmScript>().cnt = 0;
            }
        }
        else if (GameObject.Find("TT_demo_female").GetComponent<moveScene1>().cnt == 3)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                talkPanel3.SetActive(false);
                Debug.Log("girl[2]"+GameObject.Find("TT_demo_female").GetComponent<moveScene1>().cnt);
                GameObject.Find("TT_demo_female").GetComponent<moveScene1>().cnt++;
                SceneCount++;

                //GameObject.Find("TT_demo_male_A").GetComponent<AlarmScript>().cnt = 0;
            }
        }
        else if (GameObject.Find("TT_demo_male_B").GetComponent<moveScene2>().cnt == 3)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                talkPanel4.SetActive(false);
                Debug.Log("boy[2]"+GameObject.Find("TT_demo_male_B").GetComponent<moveScene2>().cnt);
                GameObject.Find("TT_demo_male_B").GetComponent<moveScene2>().cnt++;
                SceneCount++;
                //GameObject.Find("TT_demo_male_A").GetComponent<AlarmScript>().cnt = 0;
            }
        }
        if (SceneCount == 2)
        {
            nextbtn.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;  
        }
    }
}
