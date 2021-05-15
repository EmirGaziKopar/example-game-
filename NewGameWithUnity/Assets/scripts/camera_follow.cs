using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_follow : MonoBehaviour
{
    public GameObject targetObject;
    public Vector3 camera_payi;

    // Update is called once per frame
    void LateUpdate()//Update fonksiyonu çalýþtýktan hemen sonra çalýþýyor 
    {
        transform.position = targetObject.transform.position + camera_payi; //camera ile cisim arasýna pay býraktýk 
    }
}
