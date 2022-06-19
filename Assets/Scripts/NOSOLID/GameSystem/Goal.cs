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
        //PlayerManagerから取得する*************
        Manager = GameObject.FindWithTag("Player").GetComponent<PlayerManager>();
        
        //**************************************

        //最初にテキストを非表示にする
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

    //あたり判定取得*************************************
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {
            GoalText.enabled = true;
        }
    }
    //***************************************************
}
