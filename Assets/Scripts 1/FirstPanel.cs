using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]

public class FirstPanel : MonoBehaviour
{
    public GameObject talkPanel;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("exitText", 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
            
                
            
    }

    void exitText()
    {
        talkPanel.SetActive(false);
    }
}
