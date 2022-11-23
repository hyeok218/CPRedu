using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class moveScene : MonoBehaviour
{

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 5.0f))
        {
            if (hit.collider.gameObject.tag == "PATIENT")
            {
                if (Input.GetKeyDown(KeyCode.F))
                {
                    SceneManager.LoadScene(1);

                }
            }

        }
    }
}
