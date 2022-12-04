using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


[RequireComponent(typeof(Collider))]
public class StartBtn : MonoBehaviour
{

    public Image LoadingBar;
    private bool IsOn;
    private float barTime = 0.0f;


    void Start()
    {
        IsOn = false;
        LoadingBar.fillAmount = 0;
    }


    void Update()
    {
        if (IsOn)
        {
            Debug.Log(barTime);
            if (barTime <= 3.0f)
            {
                barTime += Time.deltaTime;
            }
            LoadingBar.fillAmount = barTime / 3.0f;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

    }
    public void SetGazedAt(bool gazedAt)
    {
        IsOn = gazedAt;
        barTime = 0.0f;
        if (gazedAt)
        {
            Invoke("goNext", 3.0f);
        }
        else
        {
            Debug.Log("Out");
            LoadingBar.fillAmount = 0;
        }
    }

    void goNext()
    {
        if (barTime >= 2.8f)
        {
            SceneManager.LoadScene(1);
        }
    }
}
