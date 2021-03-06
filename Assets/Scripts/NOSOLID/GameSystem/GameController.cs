//============================================================
// GameController.cs
//======================================================================
// 開発履歴
//
// 2022/06/06 制作開始
//
//======================================================================
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{


    public GameObject Enemy;
    static EnemyGenerater generater;

    int Score = 0;

    float time = 0;
    [SerializeField] float MaxTime = 3.0f;

    
    private void Awake()
    {
        
        

        generater = new EnemyGenerater(Enemy, 80);

    }


    
    void Update()
    {
        time += Time.deltaTime;

        if(time > MaxTime)
        {
            generater.Geneate();
            time = 0;
        }
        
    }

}
