using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //ÚG‚µ‚½uŠÔ
    private void OnTriggerEnter(Collider other)
    {
        //DestroySelf();
        animator.SetTrigger("Get");
    }

    //ÚG‚µ‚Ä‚¢‚éŠÔ
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Stay");
    }

    //—£‚ê‚½‚Æ‚«
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit");
    }


    private void DestroySelf()
    {
        Destroy(gameObject);
    }
}
