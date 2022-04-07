using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
       animator.SetTrigger("Walk");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Normal stage");
        //animator.SetTrigger("Walk");
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Attack Stage");
            animator.SetTrigger("RoundKick");
        }
        
      
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Idle state");
        animator.SetTrigger("Idle");
    }


}
