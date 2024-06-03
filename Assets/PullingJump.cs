using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

public class PullingJump : MonoBehaviour
{
    private Vector3 clickPosition;
    [SerializeField]
    private float jumpPower = 20;
    private Rigidbody rb;
    //Physics.gravity = new Vector3(0,-9.8,0); 

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickPosition = Input.mousePosition;
        }
        if (Input.GetMouseButtonUp(0))
        {
            //クリックした座標と離した座標の差分を算出
            Vector3 dist = clickPosition - Input.mousePosition;

            //クリックとリリースが同じ座標ならば無視
            if(dist.sqrMagnitude == 0) { return; };

            //差分を標準化し、jumpPowerを掛け合わせた値を移動量にする
            rb.velocity = dist.normalized * jumpPower;
            
        }
    }
}
