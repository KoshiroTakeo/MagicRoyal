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
                //�����Ȃ�
                Debug.Log("Grade���ݒ肳��Ă��܂���");
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

    //�����蔻��擾*************************************
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("�A�C�e���擾");
        if (collision.gameObject.tag == "Player")
        {
            //GameController.instance.AddScore(Score); //
            Destroy(this.gameObject);
        }
    }
    //***************************************************
}
