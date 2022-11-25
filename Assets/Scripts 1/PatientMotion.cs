using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatientMotion : MonoBehaviour
{
    public int count = 0;
    public int cnt = 1;
    private Animator m_animator;
    public GameObject emergency;

    // Start is called before the first frame update
    void Start()
    {
        m_animator = GetComponent<Animator>();
        emergency.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 10.0f))
        {
            //Debug.Log("범위안으로 들어옴");
            /*if (Input.GetKeyDown(KeyCode.w))
            {
                */
            if (cnt == 1)
                {
                    count = 1;
                    m_animator.SetTrigger("faint");
                    m_animator.SetFloat("count", count);
                    emergency.SetActive(true);
                    cnt = 0;
                    
                }
           // }

        }
    }
}
