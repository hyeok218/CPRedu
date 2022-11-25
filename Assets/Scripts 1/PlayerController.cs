using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator m_animator;

    private Vector3 m_velocity;

    private bool m_wasGrounded;
    private bool m_isGrounded = true;

    public float m_moveSpeed = 2.0f;
    public float m_jumpForce = 5.0f;
    public int a_cnt = 0;
    public int s_cnt = 0;
    public int h_cnt = 0;

    



    void Start()
    {
        m_animator = GetComponent<Animator>();
    }

    void Update()
    {


        m_animator.SetBool("Grounded", m_isGrounded);
        PlayerMove();
        JumpingAndLanding();

        m_wasGrounded = m_isGrounded;

        if (Input.GetKeyDown(KeyCode.Alpha1))

        {
            if (a_cnt == 0)
            {
                m_animator.SetTrigger("angry");
                a_cnt++;
            }
            else if(a_cnt == 1)
            {
                m_animator.SetTrigger("normal");
                a_cnt--;
            }


        }

        if (Input.GetKeyDown(KeyCode.Alpha2))

        {
            if (s_cnt == 0)
            {
                m_animator.SetTrigger("scary");
                s_cnt++;
                Debug.Log("scary");
            }
            else if (s_cnt == 1)
            {
                m_animator.SetTrigger("normal");
                s_cnt--;
            }


        }
        if (Input.GetKeyDown(KeyCode.Alpha3))

        {
            if (h_cnt == 0)
            {
                m_animator.SetTrigger("happy");
                h_cnt++;
            }
            else if (h_cnt == 1)
            {
                m_animator.SetTrigger("normal");
                h_cnt--;
            }


        }
        if (Input.GetKeyDown(KeyCode.Alpha4))

        {
                m_animator.SetTrigger("normal");


        }
    }

    private void PlayerMove()
    {
        CharacterController controller = GetComponent<CharacterController>();
        float gravity = 20.0f;

        if (controller.isGrounded)
        {
            m_velocity = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

            m_velocity = m_velocity.normalized;

            if (Input.GetKey(KeyCode.LeftShift))
            {
                m_velocity *= 2.0f;
            }
            m_animator.SetFloat("MoveSpeed", m_velocity.magnitude);

            if (Input.GetButtonDown("Jump"))
            {
                m_velocity.y = m_jumpForce;
            }
            else if (m_velocity.magnitude > 0.5)
            {
                transform.LookAt(transform.position + m_velocity);
            }
        }
        m_velocity.y -= gravity * Time.deltaTime;
        controller.Move(m_velocity * m_moveSpeed * Time.deltaTime);
        m_isGrounded = controller.isGrounded;
    }


    private void JumpingAndLanding()
    {
        if (!m_wasGrounded && m_isGrounded)
        {
            m_animator.SetTrigger("Land");
        }

        if (!m_isGrounded && m_wasGrounded)
        {
            m_animator.SetTrigger("Jump");
        }
    }

    //1. 캐릭터를 가운데 고정시키고 카메라가 마우스의 반대방향으로 이동?(원) https://youtu.be/sPiXLOxaICg?t=8408
    //2.기본 controller.Move에 저번에했던 goproject 넣고싶음 122번줄?
   /* Vector3 project = Vector3.Project(Mycamera.transform.forward, Vector3.up);
      goproject = Mycamera.transform.forward - project;
      goproject.Normalize();
      transform.Translate(goproject* 3.0f * Time.deltaTime);
      goproject자리에 m_velocity?*/



}




