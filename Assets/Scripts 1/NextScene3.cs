using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextScene3 : MonoBehaviour
{
    public Button btn;
    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(MoveScene);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void MoveScene()
    {
        if (GameObject.Find("repeatCount") == null)
        {
            SceneManager.LoadScene(4);
        }
        else
        {
            if (GameObject.Find("repeatCount").GetComponent<Count>().count == 1)
            {
                GameObject.Find("repeatCount").GetComponent<Count>().count++;
                SceneManager.LoadScene(4);
            }
        }
        

    }

    
}
