//============================================================
// CharacterData.cs
//======================================================================
// �J������
//
// 2022/06/03 ����J�n
//
//======================================================================
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable/Create CharacterData")]

public class CharacterData : ScriptableObject
{
    public enum CharacterType
    {
        PLAYER = 0,
        ENEMY = 1,

        MAX,
    }

    public CharacterType eSetType;

    [Header("�X�e�[�^�X")]
    public int nLV = 0;
    public float fHP = 0;
    public float fATK = 0;
    public float fDEF = 0;
    public float fSPD = 0;

    public float fJumpPower = 0;
    public float fWeight = 0;
    public int nExpPoint = 0;
    public float fMaxEXP = 0;

    [Header("���m����")]
    public float visDist = 40.0f;            //���m����
    [Header("���F����")]
    public float visAngle = 60.0f;            //���m�p
    [Header("�U������")]
    public float shootDist = 30.0f;             //�U������
    [Header("�U���Ԋu")]
    public float Atk_Interbal = 5.0f;             //�U���Ԋu


}
