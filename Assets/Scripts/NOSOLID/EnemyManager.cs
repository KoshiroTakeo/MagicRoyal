//============================================================
// EnemyManager.cs
//======================================================================
// ŠJ”­—š—ð
//
// 2022/06/04 §ìŠJŽn
//
//======================================================================
using UnityEngine;
using UnityEngine.UI;

public class EnemyManager : Character
{

    EnemyState CurrentState;
    MoveController Contoroller;
    BulletAttack CreateBullet;

    [SerializeField] GameObject Mazzle;


    Vector2 vector2;
    bool Goarrow;
    bool isFire;
    float time;



    public string Field;
    



    void Start()
    {
        InitStatus();

        SetPosition();

        Contoroller = new MoveController();

        CreateBullet = new BulletAttack();

        TargetObj = GameObject.FindWithTag("Player").transform;
        CurrentState = new Idles(this.gameObject, Anim, TargetObj, Data);


    }


    void Update()
    {
        HPChecker();

        CurrentState = CurrentState.Process();
        SelectAction((int)CurrentState.name);

        Contoroller.Move(vector2, Rb2D, this.transform, fSPD, Anim);

        if (isFire)
        {
            CreateBullet.Bullet(Mazzle, transform.localScale / 3, this.transform, (int)eType, fATK, fBulletSpeed, Anim);
            isFire = false;
        }

       
    }



    //‚ ‚½‚è”»’èŽæ“¾*************************************
    private void OnCollisionStay2D(Collision2D collision)
    {
        Field = collision.gameObject.tag;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Field = null;
    }
    //***************************************************

    void SelectAction(int _state)
    {
        switch (_state)
        {
            case 0:
                vector2 = new Vector2(0, 0);
                Goarrow = !Goarrow;
                break;

            case 1:
                if(Goarrow) vector2 = new Vector2(-1, 0);
                else vector2 = new Vector2(1, 0);
                break;

            case 2:
                if (ForPlayerPos() == "Left")
                {
                    vector2 = new Vector2(-1, 0);
                }
                else if (ForPlayerPos() == "Right")
                {
                    vector2 = new Vector2(1, 0);
                }
                break;

            case 3:
                vector2 = new Vector2(0, 0);
                time += Time.deltaTime;
                if (time > fAtkInterbal)
                {
                    isFire = true;
                    time = 0;
                }
                break;
            case 4:
                break;

            default:
                break;
           
        }
    }

    public string ForPlayerPos()
    {
        float arrow = TargetObj.position.x - this.transform.position.x;
        if (arrow < 0) return "Left";
        else return "Right";
    }
}