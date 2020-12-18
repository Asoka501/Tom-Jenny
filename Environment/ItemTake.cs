using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemTake : MonoBehaviour
{
    int item = 0;
    Text textComponent;

    // Start is called before the first frame update
    void Start()
    {
        this.textComponent = GameObject.Find("Item").GetComponent<Text>();
        this.textComponent.text = item.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("item", item);
    }

    public void AddItem()
    {
        this.item += 1;
        this.textComponent.text =  item.ToString();
    }
}