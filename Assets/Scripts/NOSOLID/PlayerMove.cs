using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Players;
public class PlayerMove : MonoBehaviour
{
    PlayerManager Manager;
    Rigidbody2D Rigid;
    


    void Start()
    {
        //PlayerManagerから取得する*************
        Manager = GetComponent<PlayerManager>();
        Rigid = Manager.GetComponent<Rigidbody2D>();
        //**************************************
        
    }
    

    //左右移動****************************************
    public void Move(float MovePower)
    {
        float inputX = Input.GetAxis("Horizontal");

        //右に移動
        if (inputX > 0)
        {
            Rigid.AddForce(transform.right * MovePower, ForceMode2D.Force);
            //Manager.Player.transform.Find("Wizard").transform.eulerAngles = new Vector3(0, 0, 0);
        }
        //左に移動
        else if (inputX < 0)
        {
            Rigid.AddForce(-transform.right * MovePower, ForceMode2D.Force);
            //Manager.Player.transform.Find("Wizard").transform.eulerAngles = new Vector3(0, 180, 0);
        }
        //止まる(アタッチされてるRigidBody2DのLinerDragが20.0であると上手くいく)
        else Rigid.velocity = Vector2.zero; 
        
    }
    //************************************************



    //ジャンプ****************************************
    public void Jump(float JumpPower)
    {
        //床に触れているならジャンプ可能
        if (Manager.Field == "Field")
        {
            Rigid.AddForce(Vector2.up * JumpPower);
            
        }
    }
    //************************************************


    
}
