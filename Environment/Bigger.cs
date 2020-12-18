using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("Call", 2);
    }

    void Call()
    {
        gameObject.transform.localScale += new Vector3(0.005f, 0, 0.005f);
    }
}
