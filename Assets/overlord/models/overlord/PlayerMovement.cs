using UnityEngine;
using System.Collections;



public class PlayerMovement : MonoBehaviour {
    public Animator anim;



	void Awake()
    {
        anim = GetComponent<Animator>();
    }



    void Update()
    {     
        if (Input.GetButton("Shift"))
        {
            anim.SetBool("Shift", true);
        }
        else
            anim.SetBool("Shift", false);
        if (Input.GetButton("Fire1"))
        {
            anim.SetBool("Attack", true);
        }
        else
            anim.SetBool("Attack", false);
        Move();
    }



    void Move()
    {
        anim.SetFloat("Forward", Input.GetAxis("Vertical"));
    }
}
