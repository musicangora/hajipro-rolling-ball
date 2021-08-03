using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    // 移動量調整用パラメータ
    public float force = 1.0f;
    private Rigidbody _rb;
    private Vector3 _forceVector = new Vector3();
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // // 動かす力の初期化
        // Vector3 _forceVector = new Vector3();

        if (Application.isMobilePlatform)
        {
            _forceVector.x = Input.acceleration.x;
            _forceVector.z = Input.acceleration.z;
        } else {
            // キー入力を検知
        _forceVector.x = Input.GetAxis("Horizontal");
        _forceVector.z = Input.GetAxis("Vertical");
        }
    }

    void FixedUpdate()
    {
        // 移動処理
        _rb.AddForce(force * _forceVector);
    }
}
