using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Character_Classes 
{
    public string Name; // 名称
    public int Life;    // 体力、無くなるとそのキャラは死ぬ
    public int Atakck;  // 攻撃力、与えるダメージに影響
    public int Deffense;// 防御力、受けるダメージに影響
    public float Speed; // 速度、各移動の速さに影響
    public int EXP;     // 経験値、レベルアップに必要
    public int Level;   // レベル、能力に上昇補正をかける

    public bool Death;  // 死亡判定、これがtrueになったら死亡処理を行う
    public bool beDamage;//ダメージ判定、これがtrueになったらダメージ処理を行う
   

    //生成時ステータスを決める*******************************************************************
    public Character_Classes(string SetName, int SetLife, int SetATK, int SetDef, float SetSPD, int Lv)
    {
        Name = SetName;
        Life = SetLife;
        Atakck = SetATK;
        Deffense = SetDef;
        Speed = SetSPD;
        Level = Lv;
        Death = false;    // 生存判定にする
        beDamage = false; // 被弾してない状態にする

    }
    //*******************************************************************************************
}
