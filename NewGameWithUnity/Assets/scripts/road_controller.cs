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



    private void OnTriggerExit2D(Collider2D collision)
    {
        transform.position += new Vector3(transform.GetChild(1).GetComponent<Renderer>().bounds.size.x * 4,0,0);
        Debug.Log("Yenileme Gerçekleşti");
            
    }
        
        
        

    
}