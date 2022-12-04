using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


[RequireComponent(typeof(Collider))]
public class EnterScripts : MonoBehaviour
{
    public GameObject talkPanel;
    public Image LoadingBar;
    private bool IsOn;
    private float barTime = 0.0f;
    public int count;


    void Start()
    {
        IsOn = false;
        LoadingBar.fillAmount = 0;
        talkPanel.SetActive(false);
    }


    void Update()
    {
        if (IsOn)
        {
            Debug.Log(GameObject.Find("TT_demo_male_A").GetComponent<Scene1Num>().num);

            Debug.Log(barTime);
            if (barTime <= 2.0f)
            {
                barTime += Time.deltaTime;
            }
            LoadingBar.fillAmount = barTime / 2.0f;
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
            Invoke("showText", 2.0f);
        }
        else
        {
            Debug.Log("Out");
            LoadingBar.fillAmount = 0;
        }
    }

    void showText()
    {
        if (barTime >= 1.8f)
        {
            talkPanel.SetActive(true);
            Invoke("exitText", 3.0f);
        }
    }

    void exitText()
    {
            
            talkPanel.SetActive(false);
             GameObject.Find("TT_demo_male_A").GetComponent<Scene1Num>().num++;
    }
}