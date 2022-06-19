//============================================================
// SoundManager.cs
//======================================================================
// äJî≠óöó
//
// 2022/06/06 êßçÏäJén
//
//======================================================================
using UnityEngine;
using System.Collections;

public class SoundManager :MonoBehaviour
{
    [SerializeField] SoundData SoundData;

    public void Select(GameObject _obj)
    {
        PlaySE(_obj, SoundData.SoundList[0]);
    }
    public void Decide(GameObject _obj)
    {
        PlaySE(_obj, SoundData.SoundList[1]);
    }
    public void Hit(GameObject _obj)
    {
        PlaySE(_obj, SoundData.SoundList[2]);
    }
    public void Death(GameObject _obj)
    {
        PlaySE(_obj, SoundData.SoundList[3]);
    }
    public void Jump(GameObject _obj)
    {
        PlaySE(_obj, SoundData.SoundList[4]);
    }
    public void LvUP(GameObject _obj)
    {
        PlaySE(_obj, SoundData.SoundList[5]);
    }
    public void GetExp(GameObject _obj)
    {
        PlaySE(_obj, SoundData.SoundList[6]);
    }
    public void Damage(GameObject _obj)
    {
        PlaySE(_obj, SoundData.SoundList[7]);
    }
    public void Attack(GameObject _obj)
    {
        PlaySE(_obj, SoundData.SoundList[8]);
    }


    void PlaySE(GameObject _obj, AudioClip _clip)
    {
        AudioSource audioSource;
        audioSource = _obj.AddComponent<AudioSource>();
        audioSource.PlayOneShot(_clip);
        
        StartCoroutine(Checking(audioSource));
    }

    private IEnumerator Checking(AudioSource audio)
    {
        while (true)
        {
            yield return new WaitForFixedUpdate();
            if (!audio.isPlaying)
            {
                Destroy(audio);
                break;
            }
        }
    }
}
