using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_follow : MonoBehaviour
{
    public GameObject targetObject;
    public Vector3 camera_payi;
    public float kuvvet_katsayisi = 0.1f;
    public float Speed_karsila = astro_hareket.speed;
    public float speed;

    

    
    
    

    
    Rigidbody2D camera_rigit; //rigitbody'e bu nesne ile ula��caz


    






    private void Start()
    {
        camera_rigit = GetComponent<Rigidbody2D>(); //yukar�da tan�mlad���m�z nesnenin ve 'rb' referans de�erinin nereyi referans alaca��n� burada belirttik 
       
    }

    
    // Update is called once per frame

    void LateUpdate()//Update fonksiyonu �al��t�ktan hemen sonra �al���yor 
    {
        camera_rigit.AddForce(transform.right * kuvvet_katsayisi);
        if (Speed_karsila >= speed  )
        {
           /* transform.position = targetObject.transform.position + camera_payi; //camera ile cisim aras�na pay b�rakt�k */
        }
        
            
    }
        
    }

    
    

