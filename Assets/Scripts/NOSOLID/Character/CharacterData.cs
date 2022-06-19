//============================================================
// CharacterData.cs
//======================================================================
// 開発履歴
//
// 2022/06/03 制作開始
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

    [Header("ステータス")]
    public int nLV = 0;
    public float fHP = 0;
    public float fATK = 0;
    public float fDEF = 0;
    public float fSPD = 0;

    public float fJumpPower = 0;
    public float fWeight = 0;
    public int nExpPoint = 0;
    public float fMaxEXP = 0;

    [Header("検知距離")]
    public float visDist = 40.0f;            //検知距離
    [Header("視認方向")]
    public float visAngle = 60.0f;            //検知角
    [Header("攻撃距離")]
    public float shootDist = 30.0f;             //攻撃距離
    [Header("攻撃間隔")]
    public float Atk_Interbal = 5.0f;             //攻撃間隔


}
