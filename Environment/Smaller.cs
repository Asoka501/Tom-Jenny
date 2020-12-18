using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Smaller : MonoBehaviour
{
    Text text;
    public float targetScale = 0.1f;
    public float shrinkSpeed = 0.001f;
    public bool shrinking = false;

    // Use this for initialization
    void Start()
    {
        shrinking = true;
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("Call", 3.5f);
        Invoke("Call1", 27);


    }
    void Call()
    {
        if (transform.localScale.x > targetScale)
        {
            var text = this.gameObject.GetComponent<Text>();
            text.enabled = true;
            transform.localScale -= new Vector3(shrinkSpeed, shrinkSpeed, 0);
        }
    }

    void Call1()
    {
        Destroy(this.gameObject);
    }
}