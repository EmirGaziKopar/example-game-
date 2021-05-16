using System.Collections; //Namespaces : kod içerisinde kullanacaðýmýz çeþitli unsurlar 
using System.Collections.Generic;
using UnityEngine; //unity ile haberleþebilmek için gerekli olan fonksiyonlarýn sýnýflarýn bulunduðu namespace'dir 

public class astro_hareket : MonoBehaviour //MonoBehavior'dan türetilmiþ aslýnda sizin eklediðiniz her bir c# dosyasý arkada hazýr bir c# dosyasýndan türetülüp buraya konuluyor
{
    public float hiz_katsayisi;
    public Rigidbody2D rb; //Astronotumun üzerinde bir rigitbody var evet fakat ben ona oyun içersinden kod içersinden nasýl müdehale edeceðim rigit body cinsinden bir referans sayesinde 
    
    public static float speed=1f; //hýzý buradan ayarlayabilirsiniz.
    // Start is called before the first frame update
    void Start() //guncelleme methodlarýndan herhangi birisi çaðýrýlmadan önce start fonksiyonu çaðýrýlýr oyun baþladýðýnda sadece ve sadece bir kez çalýþacak fonksiyonlarýn yerleþtirildiði yer
    {
        // örneðin oyun baþlangýç müziði
    }

    // Update is called once per frame
    void Update()// Oyun baþlatýldýktan sonraki aþamalarda her bir oyun karesini oluþturulmasý için her seferinde bu update fonksiyonu çalýþtýrýlýr frame baþlarken çalýþtýrýlýr
    {
        rb = GetComponent<Rigidbody2D>();
       /* speed = rb.velocity.magnitude; */ //anlýk olarak hýz almak için
    }

    private void FixedUpdate()
    {
        
        hiz_katsayisi = 0.3f;
        float yatay = Input.GetAxis("Horizontal"); //Yatay diye bir deðiþken oluþturduk buna da Input'dan gelen horizontali atadýk amaç ekranda sað sol tuþlarýna basarak bir karakteri harket ettirmek 
                                                   //Yatayda olan hareketlerimizi tanýmlamak için input managerden alan girdileri alacaðýmýz bir komut ýnput manager'de name kýsmýnda yazan Horizontal'ý kullandýk
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

        Debug.Log(yatay); //Console.WriteLine' a benzer mantýkta bunun unity kütüphanesindeki karþýlýðýda Debug.Log()'dur . Bunun baþka çýktýlar veren çeþitleri de vardýr.
                          //frameler arasýndaki zaman farkýnýn eþit olmasýný saðlar. Bu kod sayesinde horizontal deðiþkeni unity ekranýnda rahat bir þekilde okuyoruz. Peki bu horizontal deðiþkeni nasýl deðerlendirecez 


        transform.position += new Vector3(yatay * hiz_katsayisi, 0, 0); // iliþkili nesnenin mevcut konumunu tutan 'transform.position' deðiþkene ulaþýyoruz. Sonra bunun deðerini deðiþtirmek için üzerine gelip veri yapýsýna bakýyoruz 
                                                                        //Vector3 olduðunu öðrendikten sonra konumu deðiþtirmek için Debug.Log'un etki ettiði yatay deðiþkenini x'eksenine referans olarak koyuyoruz ve astronot nesnemizi a-d ve <-  -> yön tuþlarýyla hareket ettirebilir bir hale sokuyoruz.

        //Deðerler çok hýzlý bir þekilde deðiþtiði için ýþýnlanma olarak adlandýrýlan durumla karþýlaþýyoruz bunu düzenlemek için ise þunu yapmalýyýz. transform.position '+=' new Vector3(yatay, 0, 0);

        transform.position += new Vector3(0, speed * hiz_katsayisi, 0);


    }

    void Awake()
    {

    }


    /* private void OnCollisionEnter2D(Collision2D collision)//2D fizik fonksiyonlarý tarafýndan hesaplanýp geri döndürülen çarpýþma ayracý. Hangi cisimler çarpýþýyor ne kadar süre çarpýþýyor bunun gibi tüm fizik hesaplarýnýn sonuçlarý
     {                                                      // Bu Collesion2D sýnýfýndan üretilen collision nesnesi içersinde bize geri döndürülüyor 
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

