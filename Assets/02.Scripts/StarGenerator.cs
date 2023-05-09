using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarGenerator : MonoBehaviour
{
    public GameObject RedStar;
    float generateTimer = 0;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(RedStar, new Vector3(-3, 1.6F, 5), new Quaternion(0, 0, 0, 0));

        Instantiate(RedStar, new Vector3(-6, 1.6F, -5), new Quaternion(0, 0, 0, 0));

        Instantiate(RedStar, new Vector3(10, 1.6F, -6), new Quaternion(0, 0, 0, 0));


        for (int i = 0; i < 14; i++)
        {
            Instantiate(RedStar, new Vector3(Random.Range(-50, 50), 1.6F, Random.Range(-50, 50)), new Quaternion(0, 0, 0, 0));
        }
    }

    // Update is called once per frame
    void Update()
    {
        generateTimer += Time.deltaTime;

        if(generateTimer > 10)
        {
            generateTimer = 0;

            for (int i = 0; i < 4; i++)
            {
                Instantiate(RedStar, new Vector3(Random.Range(-50, 0), 1.6F, Random.Range(20, 50)), new Quaternion(0, 0, 0, 0));
                Instantiate(RedStar, new Vector3(Random.Range(50, 0), 1.6F, Random.Range(20, 50)), new Quaternion(0, 0, 0, 0));
                Instantiate(RedStar, new Vector3(Random.Range(50, 0), 1.6F, Random.Range(-10, 20)), new Quaternion(0, 0, 0, 0));
                Instantiate(RedStar, new Vector3(Random.Range(-50, 0), 1.6F, Random.Range(20, -10)), new Quaternion(0, 0, 0, 0));
            }

        }

    }
}
