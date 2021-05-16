using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public int sayac = 0;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (sayac==0)
        {
            sayac++;
            gameObject.transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic; //statik olan öðeyi Dynamic yapar 
            Debug.Log("Buraya girdi");

        }
            
    }
}
