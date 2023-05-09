using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameStart : MonoBehaviour
{
    public float leftTime = 30;
    public Text leftTimeText;

    public RectTransform StartUI;

    public RectTransform FinalUI;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKey)
        {
            Time.timeScale = 1;

            StartUI.position = new Vector3(100000000, 10000000000, 10000000000);

        }

        leftTime -= Time.deltaTime;

        leftTimeText.text = "���� �ð� : "+Mathf.Round(leftTime);

        if(leftTime < 0)
        {
            Time.timeScale = 0;

            FinalUI.anchoredPosition = new Vector3(-15, 74, 0);

            FinalUI.GetComponent<Text>().text = "����� ������ \n" + COUNTINGSTARS.Name.score + "\n" + "RŰ�� ���� �ٽ� ����";

            if(Input.GetKey(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                  
            }

           


        }

    }
}