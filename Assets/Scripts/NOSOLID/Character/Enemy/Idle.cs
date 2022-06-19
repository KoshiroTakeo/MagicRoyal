//============================================================
// Idles.cs
//======================================================================
// �J������
//
// 2022/06/04 ����J�n
//
//======================================================================
using UnityEngine;

public class Idles : EnemyState                                                                //EnemyState�̋@�\���p��(�X�[�p�[�N���X)���AEnemyState�ł��邱�Ƃ��ł���悤�ɂ���
{
    public Idles(GameObject _npc, Animator _anim, Transform _player, CharacterData _enemyData)
        : base(_npc, _anim, _player, _enemyData)                                              //base�Ōp����(EnemyState)�Ɏ��ۂɃA�N�Z�X����
    {
        name = STATE.IDLE;                                                                //�ҋ@��Ԃ֕ύX
    }


    //virtual�C���q���t����Enter��p����
    public override void Enter()                                                          //Enter���\�b�h�̓��e�𗘗p���ďo��
    {
        base.Enter();                                                                     //Enter()���獀�ڂ��p��
    }


    //virtual�C���q���t����Updata��p����
    public override void Updata()                                                         //Updata���\�b�h�̓��e�𗘗p���ďo��
    {

        if (isDeath) NextState(new Knockout(npc, anim, player, enemyData));

        if (CanSeePlayer()) NextState(new Pursues(npc, anim, player, enemyData));

        if (Random.Range(0, 1000) < 10) NextState(new Patrol(npc, anim, player, enemyData));
    }

    //virtual�C���q���t����Exit��p����
    public override void Exit()                                                            //Exit���\�b�h�̓��e�𗘗p���ďo��
    {
        base.Exit();
    }
}
