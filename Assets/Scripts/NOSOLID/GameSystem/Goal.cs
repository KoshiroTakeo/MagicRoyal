using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Players;

public class Goal : MonoBehaviour
{
    [SerializeField] Text GoalText;
    [SerializeField] Text RetryText;

    PlayerManager Manager;

    private void Start()
    {
        //PlayerManager����擾����*************
        Manager = GameObject.FindWithTag("Player").GetComponent<PlayerManager>();
        
        //**************************************

        //�ŏ��Ƀe�L�X�g���\���ɂ���
        GoalText.enabled = false;
        RetryText.enabled = false;
    }

    private void Update()
    {
        //if(Manager.Status.Death)
        //{
        //    RetryText.enabled = true;
        //    if(Input.GetKeyDown(KeyCode.Space))
        //    {
        //        Manager.ResetStatus();
        //    }

        //}
        //else
        //{
        //    RetryText.enabled = false;
        //}
    }

    //�����蔻��擾*************************************
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {
            GoalText.enabled = true;
        }
    }
    //***************************************************
}
