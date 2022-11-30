using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToHome : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 3.0f))
        {
            if (hit.collider.gameObject.tag == "AMBULANCE")
            {
                if (Input.GetKeyDown(KeyCode.F))
                {
                    SceneManager.LoadScene(0);

                }
            }

        }
    }

    void MoveScene()
    {
        SceneManager.LoadScene(0);
    }
}
