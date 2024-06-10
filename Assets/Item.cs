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

    //接触した瞬間
    private void OnTriggerEnter(Collider other)
    {
        //DestroySelf();
        animator.SetTrigger("Get");
    }

    //接触している間
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Stay");
    }

    //離れたとき
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit");
    }


    private void DestroySelf()
    {
        Destroy(gameObject);
    }
}
