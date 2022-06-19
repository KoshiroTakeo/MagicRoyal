using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemtyMove : MonoBehaviour
{
    EnemyManager Manager;
    Rigidbody2D Rigid;



    void Start()
    {
        //EnemyManager©çæ¾·é*************
        Manager = GetComponent<EnemyManager>();
        Rigid = Manager.GetComponent<Rigidbody2D>();
        //**************************************
    }


    //¶EÚ®****************************************
    public void Move(float MovePower, int Arrow)
    {
        switch(Arrow)
        {
            //Eü«
            case 1:
                
                Rigid.velocity = new Vector2(MovePower, 0.0f);
                //Manager.Enemy.GetComponent<SpriteRenderer>().flipX = true;
                //Debug.Log("Eü«" + Rigid.velocity);
                break;
            //¶ü«
            case -1:
                Rigid.velocity = new Vector2(-MovePower, 0.0f);
                //Manager.Enemy.GetComponent<SpriteRenderer>().flipX = false;
                //Debug.Log("¶ü«" + Rigid.velocity);
                break;
            //â~
            case 0:
                Rigid.velocity = new Vector2(0.0f, 0.0f);
                Debug.Log("â~" + Rigid.velocity);
                break;
        }

    }
    //************************************************
}
