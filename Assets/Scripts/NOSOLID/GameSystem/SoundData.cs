//============================================================
// SoundData.cs
//======================================================================
// ŠJ”­—š—ğ
//
// 2022/06/06 §ìŠJn
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
