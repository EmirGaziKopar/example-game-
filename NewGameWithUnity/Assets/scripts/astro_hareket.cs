using System.Collections; //Namespaces : kod i�erisinde kullanaca��m�z �e�itli unsurlar 
using System.Collections.Generic;
using UnityEngine; //unity ile haberle�ebilmek i�in gerekli olan fonksiyonlar�n s�n�flar�n bulundu�u namespace'dir 

public class astro_hareket : MonoBehaviour //MonoBehavior'dan t�retilmi� asl�nda sizin ekledi�iniz her bir c# dosyas� arkada haz�r bir c# dosyas�ndan t�ret�l�p buraya konuluyor
{
    public float hiz_katsayisi;
    public Rigidbody2D rb; //Astronotumun �zerinde bir rigitbody var evet fakat ben ona oyun i�ersinden kod i�ersinden nas�l m�dehale edece�im rigit body cinsinden bir referans sayesinde 
    
    public static float speed=1f; //h�z� buradan ayarlayabilirsiniz.
    // Start is called before the first frame update
    void Start() //guncelleme methodlar�ndan herhangi birisi �a��r�lmadan �nce start fonksiyonu �a��r�l�r oyun ba�lad���nda sadece ve sadece bir kez �al��acak fonksiyonlar�n yerle�tirildi�i yer
    {
        // �rne�in oyun ba�lang�� m�zi�i
    }

    // Update is called once per frame
    void Update()// Oyun ba�lat�ld�ktan sonraki a�amalarda her bir oyun karesini olu�turulmas� i�in her seferinde bu update fonksiyonu �al��t�r�l�r frame ba�larken �al��t�r�l�r
    {
        rb = GetComponent<Rigidbody2D>();
       /* speed = rb.velocity.magnitude; */ //anl�k olarak h�z almak i�in
    }

    private void FixedUpdate()
    {
        
        hiz_katsayisi = 0.3f;
        float yatay = Input.GetAxis("Horizontal"); //Yatay diye bir de�i�ken olu�turduk buna da Input'dan gelen horizontali atad�k ama� ekranda sa� sol tu�lar�na basarak bir karakteri harket ettirmek 
                                                   //Yatayda olan hareketlerimizi tan�mlamak i�in input managerden alan girdileri alaca��m�z bir komut �nput manager'de name k�sm�nda yazan Horizontal'� kulland�k
        float dikey = Input.GetAxis("Vertical");

        if (yatay > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (yatay < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        /*if(dikey>0)
        {
            transform.localScale = new Vector3(1, -1, 1);
        }
        else if (dikey < 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }*/

        Debug.Log(yatay); //Console.WriteLine' a benzer mant�kta bunun unity k�t�phanesindeki kar��l���da Debug.Log()'dur . Bunun ba�ka ��kt�lar veren �e�itleri de vard�r.
                          //frameler aras�ndaki zaman fark�n�n e�it olmas�n� sa�lar. Bu kod sayesinde horizontal de�i�keni unity ekran�nda rahat bir �ekilde okuyoruz. Peki bu horizontal de�i�keni nas�l de�erlendirecez 


        transform.position += new Vector3(yatay * hiz_katsayisi, 0, 0); // ili�kili nesnenin mevcut konumunu tutan 'transform.position' de�i�kene ula��yoruz. Sonra bunun de�erini de�i�tirmek i�in �zerine gelip veri yap�s�na bak�yoruz 
                                                                        //Vector3 oldu�unu ��rendikten sonra konumu de�i�tirmek i�in Debug.Log'un etki etti�i yatay de�i�kenini x'eksenine referans olarak koyuyoruz ve astronot nesnemizi a-d ve <-  -> y�n tu�lar�yla hareket ettirebilir bir hale sokuyoruz.

        //De�erler �ok h�zl� bir �ekilde de�i�ti�i i�in ���nlanma olarak adland�r�lan durumla kar��la��yoruz bunu d�zenlemek i�in ise �unu yapmal�y�z. transform.position '+=' new Vector3(yatay, 0, 0);

        transform.position += new Vector3(0, speed * hiz_katsayisi, 0);


    }

    void Awake()
    {

    }


    /* private void OnCollisionEnter2D(Collision2D collision)//2D fizik fonksiyonlar� taraf�ndan hesaplan�p geri d�nd�r�len �arp��ma ayrac�. Hangi cisimler �arp���yor ne kadar s�re �arp���yor bunun gibi t�m fizik hesaplar�n�n sonu�lar�
     {                                                      // Bu Collesion2D s�n�f�ndan �retilen collision nesnesi i�ersinde bize geri d�nd�r�l�yor 
         Debug.Log("Astronot carpti");
     }
     */

    private void OnTriggerExit2D(Collider2D collision)
    {
       
        


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
            
        if(collision.tag == "MainCamera")
        {
            Debug.Log("Oldun knaka sonunda ");
        }
        
    }
}

