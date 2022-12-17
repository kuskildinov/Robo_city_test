using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robo_state_controller : MonoBehaviour
{
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        Player_input();
    }

    public void Player_input()
    {
        if(Input.GetKey(KeyCode.Alpha1))
        {
            anim.SetInteger("state", 1);
            Debug.Log("1");
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            anim.SetInteger("state", 2);
            Debug.Log("2");
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            anim.SetInteger("state", 3);
            Debug.Log("3");
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            anim.SetInteger("state", 4);
            Debug.Log("4");
        }
        if (Input.GetKey(KeyCode.Alpha5))
        {
            anim.SetInteger("state", 5);
            Debug.Log("5");
        }
    }

    public void Idle_state()
    {
        anim.SetInteger("state", 0);
    }
}
