using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitBtn : MonoBehaviour
{
    public Button btn;
    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(ExitProgram);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void ExitProgram()
    {
        Application.Quit();
    }
}
