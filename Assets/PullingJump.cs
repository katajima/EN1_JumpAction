using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

public class PullingJump : MonoBehaviour
{
    private Vector3 clickPosition;
    [SerializeField]
    private float jumpPower = 100;
    private Rigidbody rb;
    //Physics.gravity = new Vector3(0,-9.8,0); 
    private bool isCanJump;

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
        if (isCanJump && Input.GetMouseButtonUp(0))
        {
            //クリックした座標と離した座標の差分を算出
            Vector3 dist = clickPosition - Input.mousePosition;

            //クリックとリリースが同じ座標ならば無視
            if(dist.sqrMagnitude == 0) { return; };

            //差分を標準化し、jumpPowerを掛け合わせた値を移動量にする
            rb.velocity = dist.normalized * jumpPower;
            
        }
    }

    //衝突した瞬間
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("衝突した");
    }

    //衝突している間
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("接触中");
       
        //衝突している点の情報が複数格納されている
        ContactPoint[] contacts = collision.contacts;
        //0番目の衝突情報から、衝突している点の法線を取得
        Vector3 otherNormal = contacts[0].normal;
        //上方向を示すベクトル。長さは1
        Vector3 upVector = new Vector3(0,1,0);
        //上方向と法線の内積。二つのベクトルは元の長さが1なので、cocθの結果がdotUN変数に入る
        float dodUN = Vector3.Dot(upVector, otherNormal);
        //内積値に逆三角関数arccosを掛けて角度を算出。それを度数法へ変換する。これで角度が算出できた。
        float dotDeg = Mathf.Acos(dodUN) * Mathf.Rad2Deg;
        //二つのベクトルがなす角度が45度より小さければ再びジャンプ可能とする
        if(dotDeg <= 45)
        {
            isCanJump = true;
        }

    }

    //離れたとき
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("離れたとき");
        isCanJump = false;
    }

}
