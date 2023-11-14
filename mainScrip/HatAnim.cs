using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatAnim : MonoBehaviour
{
    Animator animator;

    public static bool canWarp = true;
    public static bool canWalk = true;
    bool canProtect = true;
    // Start is called before the first frame update
    void Start()
    {
        canWarp = true;
        canWalk = true;
        canProtect = true;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A) && canWalk)
        {
            animator.SetBool("walk", true);
        }
        else
        {
            animator.SetBool("walk", false);
        }

        if (Input.GetKeyDown(KeyCode.H) && canProtect)
        {
            animator.SetTrigger("Protect");
            canWarp = false;
            canWalk = false;
            canProtect = false;
        }

        if(Input.GetKeyDown(KeyCode.J) && !canProtect)
        {
            animator.SetTrigger("UnProtect");
            canWarp = true;
            canWalk = true;
            canProtect = true;
        }
    }
}
