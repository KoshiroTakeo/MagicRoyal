//============================================================
// SoundData.cs
//======================================================================
// �J������
//
// 2022/06/06 ����J�n
//
//======================================================================
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable/Create SoundData")]

public class SoundData : ScriptableObject
{
    [Header("<SoundList>")]
    public List<AudioClip> SoundList = new List<AudioClip>();

}
