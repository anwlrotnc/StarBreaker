using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class HeeHeeBalSsa : MonoBehaviour
{
    public float force = 3000.0f;

    private Rigidbody rb;

    public GameObject Bullet;

    float bulletRemover = 0;

    public GameObject BreakParticle;

    public Transform ParticlePos;

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Target")
        {
            Destroy(this.gameObject);
            collision.gameObject.GetComponent<StarManager>().Damaged(Random.Range(1, 6));
        }

        if(collision.gameObject.tag == "BreakableObj")
        {
            Destroy(this.gameObject);
            collision.gameObject.GetComponent<ObjCtr>().Damaged(Random.Range(1, 6));
        }

        if(collision.gameObject.tag == "UnbreakableObj")
        {
            Destroy(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.AddForce(transform.forward * force);
    }

    // Update is called once per frame
    void Update()
    {
        bulletRemover += Time.deltaTime;

        if(bulletRemover > 3)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnDestroy()
    {
       
        for (int i = 0; i < 6; i++)
        {
            Instantiate(BreakParticle, ParticlePos.position, ParticlePos.rotation);
        }

    }
}
