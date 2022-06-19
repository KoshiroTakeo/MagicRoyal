using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    ScoreManager ScoreManager;

    public int Grade;
    int Score;

    void Start()
    {
        
        
        switch(Grade)
        {
            case 0:
                //‰½‚à‚È‚µ
                Debug.Log("Grade‚ªİ’è‚³‚ê‚Ä‚¢‚Ü‚¹‚ñ");
                break;

            case 1:
                Score = 100;
                break;
            case 2:
                Score = 500;
                break;
            case 3:
                Score = 1000;
                break;

        }
    }

    
    void Update()
    {
        
    }

    //‚ ‚½‚è”»’èæ“¾*************************************
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("ƒAƒCƒeƒ€æ“¾");
        if (collision.gameObject.tag == "Player")
        {
            //GameController.instance.AddScore(Score); //
            Destroy(this.gameObject);
        }
    }
    //***************************************************
}
