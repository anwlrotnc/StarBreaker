using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleRemover2 : MonoBehaviour
{
    float lifeTimer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lifeTimer += Time.deltaTime;

        if (lifeTimer > 0.15)
        {
            Destroy(this.gameObject);
        }

    }
}
