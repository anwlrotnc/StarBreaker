using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleRemover : MonoBehaviour
{
    float removeTimer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        removeTimer += Time.deltaTime;

        if ( removeTimer > Random.Range(10, 21))
        {
            Destroy(this.gameObject);
        }
        
    }
}
