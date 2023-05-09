using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{

    Camera viewCamera;

    public GameObject view;
    public GameObject view2;

    float speed = 10;

    Rigidbody rigid;



    // Start is called before the first frame update
    void Start()
    {
        viewCamera = Camera.main;

        rigid = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxis("Horizontal");
        float zMove = Input.GetAxis("Vertical");
   

        Vector3 movement = new Vector3(xMove, 0, zMove) * speed;
        rigid.velocity = movement;

        
        Vector3 mousePos = viewCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, viewCamera.transform.position.y));

        Vector3 targetPosition = new Vector3(mousePos.x, transform.position.y, mousePos.z);

        view.transform.LookAt(targetPosition, Vector3.up);

        view2.transform.LookAt(targetPosition, Vector3.up);

    }

}
