using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextScene2 : MonoBehaviour
{
    public Button btn2;
    // Start is called before the first frame update
    void Start()
    {
        btn2.onClick.AddListener(MoveScene2);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void MoveScene2()
    {
        SceneManager.LoadScene(2);
    }
}
