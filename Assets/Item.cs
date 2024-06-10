using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private Animator animator;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //�ڐG�����u��
    private void OnTriggerEnter(Collider other)
    {
        animator.SetTrigger("Get");
        audioSource.Play();
    }

    //�ڐG���Ă����
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Stay");
    }

    //���ꂽ�Ƃ�
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit");
    }


    private void DestroySelf()
    {
        Destroy(gameObject);
    }
}
