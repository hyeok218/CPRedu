using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lastmotion : MonoBehaviour
{
    public int count = 0;
    public int cnt = 1;
    private Animator m_animator;

    // Start is called before the first frame update
    void Start()
    {
        m_animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
       
            if (cnt == 1)
            {
                count = 1;
                m_animator.SetTrigger("faint");
                m_animator.SetFloat("count", count);
                cnt = 0;

            }


    }
}