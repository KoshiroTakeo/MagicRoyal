//============================================================
// EnemyState.cs
//======================================================================
// �J������
//
// 2022/06/03 ����J�n
//
//======================================================================
using UnityEngine;

public abstract class EnemyState 
{
    // �s����� =================================
    public enum STATE // �񋓌^
    {
        IDLE = 0,    // �ҋ@
        PATROL = 1,  // �x���A�p�j
        PURSUE = 2,  // �ǐ�
        ATTACK = 3,  // �U��
        SLEEP = 4,   // �s���s�\
        RUNAWAY = 5, // ����
        KNOCKOUT = 6,// ���S��

        MAX
    };
    public STATE name; //�s����Ԋm�F�p
    //===========================================



    // �C�x���g =================================
    public enum EVENT
    {
        ENTER,  // �s���J�n
        UPDATA, // �s����
        EXIT    // �s���I��
    };
    protected EVENT stage;
    //===========================================



    // �J�ڗp ===================================
    protected GameObject npc;           //�ΏۃL����
    protected Animator anim;            //�A�j���[�V����
    protected Transform player;         //�v���C���[���W
    protected CharacterData enemyData;      //���F�����Ȃǂ̏��
    protected EnemyState nextEnemyState;//���̍s��

    public bool isDeath { get; set; } = false;

    //��̊e�s����Ԃɂ́A�����̕ϐ��𓖂Ă͂߂�
    public EnemyState(GameObject _npc,  Animator _anim, Transform _player, CharacterData _enemyData)
    {
        npc = _npc;           //�s����Ԃ��Ƃ�Ώ�()
        
        anim = _anim;         //�Ώۂ̎��i�Q�Ƃ���j�A�j���[�V����
        stage = EVENT.ENTER;  //��ԊJ�n���ɂƂ�s��
        player = _player;     //���Ă���ΏہA����ɑ΂��čs�����Ƃ�
        enemyData = _enemyData;

    }
    //===========================================



    public virtual void Enter() { stage = EVENT.UPDATA; } 
    public virtual void Updata() { stage = EVENT.UPDATA; }
    public virtual void Exit() { stage = EVENT.EXIT; }

    // ������Ăяo�� ===========================
    public EnemyState Process()
    {
        //state����ǂݎ��
        if (stage == EVENT.ENTER) Enter();  //Enter�̏������s��

        if (stage == EVENT.UPDATA) Updata(); //Updata�̏������s��

        if (stage == EVENT.EXIT)      //Exit�̏������s��
        {
            Exit();
            return nextEnemyState; //���̍s���Ɉڂ�
        }

        return this; // EnemyState��Ԃ�
    }
    //===========================================



    // �A�j���Ăяo�� ===========================
    public void PlayAnimeSetFloat(string _parameters, float _force)
    {
        anim.SetFloat(_parameters, _force);
    }
    //===========================================

    // �v���C���[���m ===========================
    public bool CanSeePlayer()
    {
        Vector3 direction = player.position - npc.transform.position;  //direction�Ńv���C���[�Ƃ̋���(�ʒu)���Ƃ�
        float angle = npc.transform.rotation.y; //2�_�Ԃ̈ʒu�̊p�x��Ԃ�

        if (direction.magnitude < enemyData.visDist ) { return true; }; //�������߂��A�w��̊p�x���ɂ����݂���Ƃ�

        return false;
    }

    

    //�v���C���[�֍U������(true/false�ŕԂ�) ====
    public bool CanAttackPlayer()
    {
        Vector3 direction = player.position - npc.transform.position;  //direction�Ŏ��g�Ƃ̋���(�ʒu)���Ƃ�
        if (direction.magnitude < enemyData.shootDist) { return true; }                     //���̈ʒu���˒����ł����

        return false;
    }

    public void NextState(EnemyState enemyState)
    {
        nextEnemyState = enemyState;
        stage = EVENT.EXIT;
    }
    //===========================================
}