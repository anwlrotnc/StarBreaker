using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class COUNTINGSTARS : MonoBehaviour
{
    public static COUNTINGSTARS Name;
    public Text COUNTINGSCORE;

    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        Name = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetScore()
    {
        score += 1;

        COUNTINGSCORE.text = "Á¡¼ö : " + score;

        

    }

}
