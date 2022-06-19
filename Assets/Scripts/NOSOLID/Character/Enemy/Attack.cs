//============================================================
// Attacks.cs
//======================================================================
// �J������
//
// 2022/06/04 ����J�n
//
//======================================================================
using UnityEngine;

public class Attacks : EnemyState                                                                //EnemyState�̋@�\���p��(�X�[�p�[�N���X)���AEnemyState�ł��邱�Ƃ��ł���悤�ɂ���
{
    public Attacks(GameObject _npc, Animator _anim, Transform _player, CharacterData _enemyData)
        : base(_npc, _anim, _player, _enemyData)                                              //base�Ōp����(EnemyState)�Ɏ��ۂɃA�N�Z�X����
    {
        name = STATE.ATTACK;                                                                //�ҋ@��Ԃ֕ύX
    }


    //virtual�C���q���t����Enter��p����
    public override void Enter()                                                          //Enter���\�b�h�̓��e�𗘗p���ďo��
    {
        base.Enter();                                                                     //Enter()���獀�ڂ��p��
    }


    //virtual�C���q���t����Updata��p����
    public override void Updata()                                                         //Updata���\�b�h�̓��e�𗘗p���ďo��
    {
        if (!CanAttackPlayer()) NextState(new Idles(npc, anim, player, enemyData));
    }

    //virtual�C���q���t����Exit��p����
    public override void Exit()                                                            //Exit���\�b�h�̓��e�𗘗p���ďo��
    {
        base.Exit();
    }
}