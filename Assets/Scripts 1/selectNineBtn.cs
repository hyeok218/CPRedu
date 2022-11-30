using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class selectNineBtn : MonoBehaviour
{
    public GameObject talkPanel;
    public Button btn;
    // Start is called before the first frame update
    void Start()
    {
        talkPanel.SetActive(false);
        btn.onClick.AddListener(showpanel);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            talkPanel.SetActive(false);
        }
    }

    void showpanel()
    {
        talkPanel.SetActive(true);
    }
}
