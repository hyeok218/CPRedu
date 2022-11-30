using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene4btn : MonoBehaviour
{
    public GameObject talkPanel;
    public int cnt = 0;
    // Start is called before the first frame update
    void Start()
    {
        talkPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(GameObject.Find("GameObject").GetComponent<Count>().count);
        if (GameObject.Find("repeatCount").GetComponent<Count>().count == 1)
        {
            
            talkPanel.SetActive(true);
            if (Input.GetMouseButton(0))
            {
                SceneManager.LoadScene(3);
            }
        }
        else if (GameObject.Find("repeatCount").GetComponent<Count>().count == 3)
        {
            talkPanel.SetActive(true);
            if (Input.GetMouseButton(0))
            {
                SceneManager.LoadScene(5);
            }
        }
    }

    
}
