using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Collider))]
public class NextScene : MonoBehaviour
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
			if (barTime <= 5.0f)
			{
				barTime += Time.deltaTime;
			}
			LoadingBar.fillAmount = barTime / 5.0f;
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
			SceneManager.LoadScene(2);
		}
        else
		{
			Debug.Log("Out");
			LoadingBar.fillAmount = 0;
		}


	}
}

