using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationScript : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Debug.Log("animator");
    }

    // Update is called once per frame
    void Update()
    {
        bool forwardKey = Input.GetKey("w");
        bool forwardKey1 = Input.GetKey("a");
        bool forwardKey2 = Input.GetKey("d");
        bool isWalking = animator.GetBool("isWalking");
        if (!isWalking &&( forwardKey | forwardKey1 | forwardKey2))
        {
            animator.SetBool("isWalking", true);
        }

        if(isWalking && !(forwardKey | forwardKey1 | forwardKey2))
        {
            animator.SetBool("isWalking", false);
        }
    }
}
