using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Players;

public class BulletManager : MonoBehaviour
{
    //Playerのステータス
    PlayerManager PlayerStatus;

    void Start()
    {
        PlayerStatus = GameObject.FindWithTag("Player").GetComponent<PlayerManager>();
    }

    //画面外に出たら消す*********************************
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
    //***************************************************

    //あたり判定取得*************************************
    private void OnCollisionStay2D(Collision2D collision)
    {
        
    }

    //物に当たった時に処理する+++++++++++++++++++++++++++
    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch(collision.gameObject.tag)
        {
            case "Enemy" :
                //collision.gameObject.GetComponent<EnemyManager>().currentLife -= PlayerStatus.Status.Atakck;
                Destroy(gameObject);
                break;

            default:
                Destroy(gameObject);
                break;
        }
        
    }
    //+++++++++++++++++++++++++++++++++++++++++++++++++++
    //***************************************************
}
