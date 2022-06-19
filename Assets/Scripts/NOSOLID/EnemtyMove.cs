using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemtyMove : MonoBehaviour
{
    EnemyManager Manager;
    Rigidbody2D Rigid;



    void Start()
    {
        //EnemyManager����擾����*************
        Manager = GetComponent<EnemyManager>();
        Rigid = Manager.GetComponent<Rigidbody2D>();
        //**************************************
    }


    //���E�ړ�****************************************
    public void Move(float MovePower, int Arrow)
    {
        switch(Arrow)
        {
            //�E����
            case 1:
                
                Rigid.velocity = new Vector2(MovePower, 0.0f);
                //Manager.Enemy.GetComponent<SpriteRenderer>().flipX = true;
                //Debug.Log("�E����" + Rigid.velocity);
                break;
            //������
            case -1:
                Rigid.velocity = new Vector2(-MovePower, 0.0f);
                //Manager.Enemy.GetComponent<SpriteRenderer>().flipX = false;
                //Debug.Log("������" + Rigid.velocity);
                break;
            //��~
            case 0:
                Rigid.velocity = new Vector2(0.0f, 0.0f);
                Debug.Log("��~" + Rigid.velocity);
                break;
        }

    }
    //************************************************
}
