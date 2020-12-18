using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CatController : MonoBehaviour
{
    public float speed = 3;
    public float speedy = 3;


    //public GameObject targetPlayer;


    // Start is called before the first frame update
    void Start()
    {
    }


    // Update is called once per frame
    void Update()
    {
        Invoke("Call", 2f);

        Move();

        //var aim = this.targetPlayer.transform.position - this.transform.position;
        //var look = Quaternion.LookRotation(aim, Vector3.up);
        //this.transform.localRotation = look;


    }

    void Call()
    {
        this.transform.position += new Vector3(0, 0, speedy * Time.deltaTime);
    }

    void Move()
    {
        if (Input.GetKey("left") == true)
        {
            this.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("right") == true)
        {
            this.transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Block")
        {
            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "Coin")
        {
            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "Vehicle")
        {
            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("EndScene");
        }
    }
}

