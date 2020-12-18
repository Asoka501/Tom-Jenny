using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSlide : MonoBehaviour
{
    //float型を変数moveStateで宣言します。
    public float moveState;
    //float型を変数speedで宣言します。
    public float speed;
    //Vector3型を変数vectorで宣言します。
    Vector3 vector;
    // Start is called before the first frame update
    void Start()
    {
        //初期位置を保存します。
        vector = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        //x軸に移動する移動範囲とスピードの計算をします。
        float x = moveState * Mathf.Sin(Time.time * speed);
        //割当られた数値を元にx軸のポジションを決定します。
        transform.localPosition = vector + new Vector3(x, 0, 0);
    }
}
