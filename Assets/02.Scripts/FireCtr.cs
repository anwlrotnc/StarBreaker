using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCtr : MonoBehaviour
{
    public GameObject Bullet;          
    public Transform firePos;            

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
         
            Fire();

        }
}
    void Fire()
    {
        Instantiate(Bullet, firePos.position, firePos.rotation);
    }
}



