using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseHelp : MonoBehaviour
{
    public Button btn;
    public GameObject helpPanel;
    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(closeHelp);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void closeHelp()
    {
        helpPanel.SetActive(false);
    }
}