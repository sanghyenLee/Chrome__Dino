using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sliding : MonoBehaviour
{
    private Animator animator;
    private bool isSliding = true;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent< Animator >();
    }

    // Update is called once per frame
    void Update()
    {

        bool canSlide = animator.GetBool("IsFly") == false;
        if (canSlide)
        {
            if (isSliding)
            {
                bool isKeyUp = Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.DownArrow);
                if (isKeyUp)
                {
                    isSliding = false;
                    animator.SetBool("isCruch", isSliding);
                }
            }
            else
            {
                bool isKeyDown = Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.DownArrow);
                if (isKeyDown)
                {
                    isSliding = true;
                    animator.SetBool("isCruch", isSliding);
                }
            }
        }
    }
}
