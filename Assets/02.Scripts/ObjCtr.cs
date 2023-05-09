using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjCtr : MonoBehaviour
{
    public int Box_Hp = 12;
    public GameObject BoxParticle1;
    public GameObject BoxParticle2;
    public Transform ParticlePos1;
    public Transform ParticlePos2;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Damaged(int Damage)
    {
        Box_Hp -= Damage;

        Vector3 boxPos = this.gameObject.transform.position;

        if(Box_Hp < 0)
        {
            Destroy(this.gameObject);

            for(int i = 0; i < 14; i ++ )
            {
                Instantiate(BoxParticle1, ParticlePos1.position, ParticlePos1.rotation);
            }

            for (int i = 0; i < 14; i ++)
            {
                Instantiate(BoxParticle2, ParticlePos2.position, ParticlePos2.rotation);
            }


        }
    }
}
