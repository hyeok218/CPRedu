using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Collider))]
public class cshPointerEvent : MonoBehaviour
{

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Application.Quit();
		}
	}
	public void SetGazedAt(bool gazedAt)
	{
		if (gazedAt)
			Debug.Log("In");
		else
			Debug.Log("Out");

	}
}
