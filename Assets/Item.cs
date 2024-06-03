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

    //接触した瞬間
    private void OnTriggerEnter(Collider other)
    {
        DestroySelf();
        //Debug.Log("Enter");
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
