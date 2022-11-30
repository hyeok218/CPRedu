using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moveNect : MonoBehaviour
{
    public Button btn;
    public GameObject neck;
    public GameObject talkPanel;
    public int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        //talkPanel.SetActive(false);
        btn.onClick.AddListener(MoveNeck);
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void MoveNeck()
    {
        neck.transform.position = new Vector3(100, 0, -270);
        neck.transform.localEulerAngles = new Vector3(0, 0, 20);
        GameObject.Find("repeatCount").GetComponent<Count>().count++;
        btn.gameObject.SetActive(false);
    }

    
}
