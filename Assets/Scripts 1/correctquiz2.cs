using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


[RequireComponent(typeof(Collider))]
public class correctquiz2 : MonoBehaviour
{
    public Image LoadingBar;
    private bool IsOn;
    private float barTime = 0.0f;
    public int count;
    public GameObject player;


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
            if (barTime <= 1.0f)
            {
                barTime += Time.deltaTime;
            }
            LoadingBar.fillAmount = barTime / 1.0f;
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
            Invoke("goNext", 1.0f);
        }
        else
        {
            Debug.Log("Out");
            LoadingBar.fillAmount = 0;
        }
    }

    void goNext()
    {
        if (barTime >= 0.8f)
        {
            player.transform.position = new Vector3(-4818, -5013, -5289);
        }
    }

}