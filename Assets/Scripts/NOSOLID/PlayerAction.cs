using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Players;
public class PlayerAction : MonoBehaviour
{
    PlayerManager Manager;
    Rigidbody2D Rigid;
    AudioSource Sound;
    GameObject Player; //�v���C���[���g
    public GameObject Bullet; //�e��
    GameObject MuzzleCircle; //����
    GameObject Muzzle; //�e��

    public float BrastPower;
    
    void Start()
    {
        Manager = GetComponent<PlayerManager>();
        //Player = Manager.Player;
        MuzzleCircle = Player.transform.Find("MuzzleCircle").gameObject;  //�e�𔭐�������e���̎擾
        Muzzle = MuzzleCircle.transform.Find("Muzzle").gameObject;  //�e�𔭐�������e���̎擾
        Rigid = Manager.GetComponent<Rigidbody2D>();
        Sound = Manager.GetComponent<AudioSource>();
        BrastPower = 100;
        //Bullet = (GameObject)Resources.Load("Prefabs/Bullet"); //�e�̎擾

    }

    //�e�𐶐�*******************************************
    public void Shot(float Power)
    {              
        GameObject Bullets = Instantiate(Bullet.gameObject, Muzzle.transform.position, Muzzle.transform.rotation); // �e���e���Ɠ����ꏊ�A���������ɐ�������
        Vector3 Force; // �e�ɂ������
        Force = Muzzle.transform.up * Power; // �e�ɂ�����͂��e���̑O�����ɂ���
        Bullets.GetComponent<Rigidbody2D>().velocity = Force; // �e�ɗ͂�������
        Sound.Play();
    }
    //***************************************************

    //�u���X�g*******************************************
    public void Brast(float HopingPower)
    {
        //�}�Y���ʒu����͂��Z�o
        Vector2 Force = Player.transform.position - Muzzle.transform.position;

        //�v���C���[���}�Y���̔��Ε����ɉE�N���b�N�Ŕ�΂�
        Rigid.AddForce(new Vector2(Force.x * BrastPower, Force.y * BrastPower), ForceMode2D.Impulse); 
    }
    //***************************************************

    //�}�Y���ʒu�ړ�*************************************
    public void MazzulePoint()
    {
        //�}�E�X�ʒu���擾
        var pos = Camera.main.WorldToScreenPoint(transform.localPosition);
        //�ʒu������������߂�
        var rotation = Quaternion.LookRotation(Vector3.forward , Input.mousePosition - pos);
        MuzzleCircle.gameObject.transform.localRotation = rotation;
    }
    //***************************************************
}
