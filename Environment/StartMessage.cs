using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartMessage : MonoBehaviour
{
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("Call", 1);
    }

    void Call()
    {
        var text = this.gameObject.GetComponent<Text>();
        text.enabled = false;
    }
}
