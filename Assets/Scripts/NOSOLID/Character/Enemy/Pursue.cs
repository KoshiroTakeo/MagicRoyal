//============================================================
// Pursues.cs
//======================================================================
// 開発履歴
//
// 2022/06/04 制作開始
//
//======================================================================
using UnityEngine;

public class Pursues : EnemyState                                                                //EnemyStateの機能を継承(スーパークラス)し、EnemyStateでやれることをできるようにする
{
    public Pursues(GameObject _npc, Animator _anim, Transform _player, CharacterData _enemyData)
        : base(_npc, _anim, _player, _enemyData)                                              //baseで継承元(EnemyState)に実際にアクセスする
    {
        name = STATE.PURSUE;                                                                //待機状態へ変更
    }


    //virtual修飾子が付いたEnterを用いる
    public override void Enter()                                                          //Enterメソッドの内容を利用して出力
    {
        base.Enter();                                                                     //Enter()から項目を継承
    }


    //virtual修飾子が付いたUpdataを用いる
    public override void Updata()                                                         //Updataメソッドの内容を利用して出力
    {
        PlayAnimeSetFloat("isMove", 0);

        if (isDeath) NextState(new Knockout(npc, anim, player, enemyData));

        if (CanAttackPlayer()) NextState(new Attacks(npc, anim, player, enemyData));
        else if (!CanSeePlayer()) NextState(new Idles(npc, anim, player, enemyData));
    }

    //virtual修飾子が付いたExitを用いる
    public override void Exit()                                                            //Exitメソッドの内容を利用して出力
    {
        base.Exit();
    }
}
