using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class StarManager : MonoBehaviour
{
    public int Star_Hp = 5;

    public GameObject StarParticle;
    public Transform ParticlePos1;
    public Transform ParticlePos2;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0 + 0.3f, 0);
    }

    public void Damaged(int Damage)
    {
        Star_Hp -= Damage;

        if (Star_Hp < 0)
        { 
            COUNTINGSTARS.Name.GetScore();


            Destroy(this.gameObject);

            for(int i =0; i < 14; i ++)
            {

                Instantiate(StarParticle, ParticlePos1.position, ParticlePos1.rotation);

                Instantiate(StarParticle, ParticlePos2.position, ParticlePos2.rotation);

            }

          

        }
    }
}
