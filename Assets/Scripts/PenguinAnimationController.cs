using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinAnimationController : MonoBehaviour
{
    private Animator animator = null;
    [SerializeField] private bool jump = false;
    public bool isIdle = false;

    private PenguinAnimationController[] penguins = null;
    void Start()
    {
        animator = GetComponent<Animator>();
        if (jump)
            animator.SetBool("Jump", true);



        penguins = FindObjectsOfType<PenguinAnimationController>();
    }

    private void FixedUpdate()
    {
        for(int i = 0; i < penguins.Length; i++)
        {
            if (penguins[i].isIdle)
                animator.SetBool("IsIdle", true);
        }
    }

    public void OnMouseDown()
    {
        if (!jump)
        {
            animator.SetBool("IsIdle", true);
            isIdle = true;
        }       
    }

}
