using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Players;

public class BulletManager : MonoBehaviour
{
    //Player�̃X�e�[�^�X
    PlayerManager PlayerStatus;

    void Start()
    {
        PlayerStatus = GameObject.FindWithTag("Player").GetComponent<PlayerManager>();
    }

    //��ʊO�ɏo�������*********************************
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
    //***************************************************

    //�����蔻��擾*************************************
    private void OnCollisionStay2D(Collision2D collision)
    {
        
    }

    //���ɓ����������ɏ�������+++++++++++++++++++++++++++
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
