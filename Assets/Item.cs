using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //�ڐG�����u��
    private void OnTriggerEnter(Collider other)
    {
        DestroySelf();
        //Debug.Log("Enter");
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
