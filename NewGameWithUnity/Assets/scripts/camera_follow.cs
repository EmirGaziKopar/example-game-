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



    

    

    
    
    

    
    Rigidbody2D camera_rigit; //rigitbody'e bu nesne ile ulaþýcaz


    






    private void Start()
    {
        camera_rigit = GetComponent<Rigidbody2D>(); //yukarýda tanýmladýðýmýz nesnenin ve 'rb' referans deðerinin nereyi referans alacaðýný burada belirttik 
       
    }


    // Update is called once per frame

    private void FixedUpdate()
    {
        zaman += Time.deltaTime;
        if (zaman <= 7 && zaman >= 6 && sayac != 1)
        {
            sayac++;
            astro_hareket.speed *= 1.1f; //buradan kamera hýzý il birlikte astronot hýzýnýda artýrmýþ olduk 
            hiz *= 1.1f;
            camera_rigit.velocity = transform.right * hiz * Time.deltaTime;
            Debug.Log("Hizlan !!!");
        }
        camera_rigit.velocity = transform.right * hiz * Time.deltaTime;
    }
    void LateUpdate()//Update fonksiyonu çalýþtýktan hemen sonra çalýþýyor 
    {
        
        
        
        /*camera_rigit.AddForce(transform.right * kuvvet_katsayisi);*/
       
       /* 
         if (Speed_karsila >= speed  )
        {
           transform.position = targetObject.transform.position + camera_payi; //camera ile cisim arasýna pay býraktýk 
        } 

         */
        
            
    }

   /* private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "yenile")
        {
            Debug.Log("oldun çýk!!!");
        }
       
    }  */ //Bu çalýþmadý 

}

    
    

