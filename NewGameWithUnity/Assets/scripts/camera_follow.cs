using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_follow : MonoBehaviour
{
    public GameObject targetObject;
    public Vector3 camera_payi;
    public float kuvvet_katsayisi = 0.1f;
    public float Speed_karsila = astro_hareket.speed;
    /*public float speed;*/
    public static float hiz = 500f;

    public float zaman;

    public static int sayac;



    

    

    
    
    

    
    Rigidbody2D camera_rigit; //rigitbody'e bu nesne ile ula��caz


    






    private void Start()
    {
        camera_rigit = GetComponent<Rigidbody2D>(); //yukar�da tan�mlad���m�z nesnenin ve 'rb' referans de�erinin nereyi referans alaca��n� burada belirttik 
       
    }


    // Update is called once per frame

    private void FixedUpdate()
    {
        zaman += Time.deltaTime;
        if (zaman <= 7 && zaman >= 6 && sayac != 1)
        {
            sayac++;
            astro_hareket.speed *= 1.1f; //buradan kamera h�z� il birlikte astronot h�z�n�da art�rm�� olduk 
            hiz *= 1.1f;
            camera_rigit.velocity = transform.right * hiz * Time.deltaTime;
            Debug.Log("Hizlan !!!");
        }
        camera_rigit.velocity = transform.right * hiz * Time.deltaTime;
    }
    void LateUpdate()//Update fonksiyonu �al��t�ktan hemen sonra �al���yor 
    {
        
        
        
        /*camera_rigit.AddForce(transform.right * kuvvet_katsayisi);*/
       
       /* 
         if (Speed_karsila >= speed  )
        {
           transform.position = targetObject.transform.position + camera_payi; //camera ile cisim aras�na pay b�rakt�k 
        } 

         */
        
            
    }

   /* private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "yenile")
        {
            Debug.Log("oldun ��k!!!");
        }
       
    }  */ //Bu �al��mad� 

}

    
    

