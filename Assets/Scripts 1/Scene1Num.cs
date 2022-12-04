using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene1Num : MonoBehaviour
{
    public int num;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(num == 3)
        {
            goNext();
        }
    }
    void goNext()
    {
        SceneManager.LoadScene(2);
    }
}
