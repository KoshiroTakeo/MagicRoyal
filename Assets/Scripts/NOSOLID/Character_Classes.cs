using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Character_Classes 
{
    public string Name; // ����
    public int Life;    // �̗́A�����Ȃ�Ƃ��̃L�����͎���
    public int Atakck;  // �U���́A�^����_���[�W�ɉe��
    public int Deffense;// �h��́A�󂯂�_���[�W�ɉe��
    public float Speed; // ���x�A�e�ړ��̑����ɉe��
    public int EXP;     // �o���l�A���x���A�b�v�ɕK�v
    public int Level;   // ���x���A�\�͂ɏ㏸�␳��������

    public bool Death;  // ���S����A���ꂪtrue�ɂȂ����玀�S�������s��
    public bool beDamage;//�_���[�W����A���ꂪtrue�ɂȂ�����_���[�W�������s��
   

    //�������X�e�[�^�X�����߂�*******************************************************************
    public Character_Classes(string SetName, int SetLife, int SetATK, int SetDef, float SetSPD, int Lv)
    {
        Name = SetName;
        Life = SetLife;
        Atakck = SetATK;
        Deffense = SetDef;
        Speed = SetSPD;
        Level = Lv;
        Death = false;    // ��������ɂ���
        beDamage = false; // ��e���ĂȂ���Ԃɂ���

    }
    //*******************************************************************************************
}
