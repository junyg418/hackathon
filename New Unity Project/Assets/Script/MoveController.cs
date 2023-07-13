using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MoveController : MonoBehaviour
{
    Vector2 position;
    public float Speed = 1;

    public Animator animator;

    void Start()
    {
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            position.x -= Speed * Time.deltaTime;
            animator.SetBool("isleft", true);
        }
        else if(Input.GetKeyUp(KeyCode.A))
        {
            animator.SetBool("isleft", false);
        }
            
        if (Input.GetKey(KeyCode.D))
        {
            position.x += Speed * Time.deltaTime;
            animator.SetBool("isright", true);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("isright", false);
        }

        if (Input.GetKey(KeyCode.W))
        {
            position.y += Speed * Time.deltaTime;
            animator.SetBool("isback", true);
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetBool("isback", false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            position.y -= Speed * Time.deltaTime;
            animator.SetBool("isfront", true);
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            animator.SetBool("isfront", false);
        }

        transform.position = position;
    }
}
