using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowHelp : MonoBehaviour
{
    public Button btn;
    public GameObject helpPanel;
    // Start is called before the first frame update
    void Start()
    {
        helpPanel.SetActive(false);
        btn.onClick.AddListener(showHelp);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void showHelp()
    {
        helpPanel.SetActive(true);
    }
}
