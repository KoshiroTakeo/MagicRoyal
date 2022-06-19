//============================================================
// StutasWindow.cs
//======================================================================
// äJî≠óöó
//
// 2022/06/06 êßçÏäJén
//
//======================================================================
using UnityEngine;
using TMPro;

public class StutasWindow : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI StutasText;
    
    public void ShowStutas(int _lv, float _hp, float _atk, float _def, float _spd)
    {
        StutasText.text =
            "LV  : " + _lv + "\n" +
            "HP  : " + (int)_hp + "\n" +
            "ATK : " + (int)_atk + "\n" +
            "DEF  : " + (int)_def + "\n" +
            "SPD  : " + (int)_spd + "\n";
            
    }
}
