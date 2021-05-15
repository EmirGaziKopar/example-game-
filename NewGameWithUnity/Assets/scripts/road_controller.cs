using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class road_controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "yenile")
        {
            /*transform.position += new Vector3(transform.GetChild(0).GetComponent<Renderer>().bounds.size.x * 2, 0, 0); //Yolun mevcut konumunu bizim yolumuzun bittiði yere aldýk.*/
            Debug.Log("yenile !!!");
        }

    }
}