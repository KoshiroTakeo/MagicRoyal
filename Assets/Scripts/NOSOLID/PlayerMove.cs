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
        //PlayerManager����擾����*************
        Manager = GetComponent<PlayerManager>();
        Rigid = Manager.GetComponent<Rigidbody2D>();
        //**************************************
        
    }
    

    //���E�ړ�****************************************
    public void Move(float MovePower)
    {
        float inputX = Input.GetAxis("Horizontal");

        //�E�Ɉړ�
        if (inputX > 0)
        {
            Rigid.AddForce(transform.right * MovePower, ForceMode2D.Force);
            //Manager.Player.transform.Find("Wizard").transform.eulerAngles = new Vector3(0, 0, 0);
        }
        //���Ɉړ�
        else if (inputX < 0)
        {
            Rigid.AddForce(-transform.right * MovePower, ForceMode2D.Force);
            //Manager.Player.transform.Find("Wizard").transform.eulerAngles = new Vector3(0, 180, 0);
        }
        //�~�܂�(�A�^�b�`����Ă�RigidBody2D��LinerDrag��20.0�ł���Ə�肭����)
        else Rigid.velocity = Vector2.zero; 
        
    }
    //************************************************



    //�W�����v****************************************
    public void Jump(float JumpPower)
    {
        //���ɐG��Ă���Ȃ�W�����v�\
        if (Manager.Field == "Field")
        {
            Rigid.AddForce(Vector2.up * JumpPower);
            
        }
    }
    //************************************************


    
}
