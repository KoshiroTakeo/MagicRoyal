using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Players;
public class PlayerAction : MonoBehaviour
{
    PlayerManager Manager;
    Rigidbody2D Rigid;
    AudioSource Sound;
    GameObject Player; //プレイヤー自身
    public GameObject Bullet; //弾丸
    GameObject MuzzleCircle; //方向
    GameObject Muzzle; //銃口

    public float BrastPower;
    
    void Start()
    {
        Manager = GetComponent<PlayerManager>();
        //Player = Manager.Player;
        MuzzleCircle = Player.transform.Find("MuzzleCircle").gameObject;  //弾を発生させる銃口の取得
        Muzzle = MuzzleCircle.transform.Find("Muzzle").gameObject;  //弾を発生させる銃口の取得
        Rigid = Manager.GetComponent<Rigidbody2D>();
        Sound = Manager.GetComponent<AudioSource>();
        BrastPower = 100;
        //Bullet = (GameObject)Resources.Load("Prefabs/Bullet"); //弾の取得

    }

    //弾を生成*******************************************
    public void Shot(float Power)
    {              
        GameObject Bullets = Instantiate(Bullet.gameObject, Muzzle.transform.position, Muzzle.transform.rotation); // 弾を銃口と同じ場所、同じ向きに生成する
        Vector3 Force; // 弾にかける力
        Force = Muzzle.transform.up * Power; // 弾にかける力を銃口の前方向にする
        Bullets.GetComponent<Rigidbody2D>().velocity = Force; // 弾に力をかける
        Sound.Play();
    }
    //***************************************************

    //ブラスト*******************************************
    public void Brast(float HopingPower)
    {
        //マズル位置から力を算出
        Vector2 Force = Player.transform.position - Muzzle.transform.position;

        //プレイヤーをマズルの反対方向に右クリックで飛ばす
        Rigid.AddForce(new Vector2(Force.x * BrastPower, Force.y * BrastPower), ForceMode2D.Impulse); 
    }
    //***************************************************

    //マズル位置移動*************************************
    public void MazzulePoint()
    {
        //マウス位置を取得
        var pos = Camera.main.WorldToScreenPoint(transform.localPosition);
        //位置から向きを決める
        var rotation = Quaternion.LookRotation(Vector3.forward , Input.mousePosition - pos);
        MuzzleCircle.gameObject.transform.localRotation = rotation;
    }
    //***************************************************
}
