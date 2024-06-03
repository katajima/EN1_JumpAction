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
            //�N���b�N�������W�Ɨ��������W�̍������Z�o
            Vector3 dist = clickPosition - Input.mousePosition;

            //�N���b�N�ƃ����[�X���������W�Ȃ�Ζ���
            if(dist.sqrMagnitude == 0) { return; };

            //������W�������AjumpPower���|�����킹���l���ړ��ʂɂ���
            rb.velocity = dist.normalized * jumpPower;
            
        }
    }
}
