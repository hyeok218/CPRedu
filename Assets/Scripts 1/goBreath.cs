using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


[RequireComponent(typeof(Collider))]
public class goBreath : MonoBehaviour
{

    public Image LoadingBar;
    private bool IsOn;
    private float barTime = 0.0f;
    public int count;
    public GameObject neck;
    public GameObject talkPanel;


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

            Invoke("MoveNeck", 2.0f);
        }
        else
        {
            Debug.Log("Out");
            LoadingBar.fillAmount = 0;
        }
    }

    void MoveNeck()
    {

        if (barTime >= 1.8f)
        {
            Debug.Log("aaa");
            talkPanel.SetActive(true);
            Invoke("goNext", 3.0f);
        }

    }

    void goNext()
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