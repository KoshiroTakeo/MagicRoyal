//============================================================
// SoundData.cs
//======================================================================
// 開発履歴
//
// 2022/06/06 制作開始
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
