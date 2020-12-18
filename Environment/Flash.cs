using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flash : MonoBehaviour
{
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("Call", 0.5f);
        Invoke("Call1", 2.5f);
    }

    void Call()
    {
        var text = this.gameObject.GetComponent<Text>();
        text.enabled = true;
    }

    void Call1()
    {
        Destroy(this.gameObject);
    }
}
