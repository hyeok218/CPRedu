using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterScripts : MonoBehaviour
{
    public GameObject talkPanel;
    public GameObject talkPanel2;
    public GameObject a;
    int count;
    // Start is called before the first frame update
    void Start()
    {
        talkPanel2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("TT_demo_male_A").GetComponent<AlarmScript>().cnt == 1)
        {

            if (Input.GetKeyDown(KeyCode.F))
            {

                talkPanel.SetActive(false);
                talkPanel2.SetActive(true);
                GameObject.Find("TT_demo_male_A").GetComponent<AlarmScript>().cnt++;
            }
        }
        
    }
}
