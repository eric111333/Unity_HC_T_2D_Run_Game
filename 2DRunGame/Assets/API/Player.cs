using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    #region 欄位
    [Header("移動速度"), Range(0, 1000)]
    public float speed = 5;
    [Header("跳躍高度"), Range(0, 1000)]
    public int jump = 350;
    [Header("血量"), Range(0, 2000)]
    public float hp = 500;
    public float hpMax = 500;
    [Header("血條")]
    public Image imageHp;
    int jump2 = 2;

    public bool isGround;
    public int coin;

    public AudioClip soundHit;
    public AudioClip soundSlide;
    public AudioClip soundJump;
    public AudioClip soundCoin;

    public Animator ani;
    public Rigidbody2D rig;
    public CapsuleCollider2D cap;
    public AudioSource aud;
    [Header("金幣數量")]
    public Text textcoin;

    [Header("結束畫面")]
    public GameObject final;
    private bool dead;

    #endregion

    #region 方法
    /// <summary>
    /// 移動
    /// </summary>
    private void Move()
    {
        transform.Translate(speed*Time.deltaTime, 0, 0);
    }
    /// <summary>
    /// 跳躍
    /// </summary>
    private void Jump()
    {

        

        bool space = Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W);
        //bool up = Input.GetKeyDown(KeyCode.UpArrow);
        RaycastHit2D hit = Physics2D.Raycast(transform.position + new Vector3(0, -0.8f), -transform.up, 0.01f, 1 << 8);
        if (hit)
        {
            isGround = true;
            jump2 = 2;
            ani.SetBool("jump switch", false);
        }
        else
        {
            isGround = false;
        }

        if (isGround || jump2>0)
        {
            if (space)
            {
                ani.SetBool("jump switch", true);
                rig.AddForce(new Vector2(0, jump));
                aud.PlayOneShot(soundJump, 05f);
                jump2--;
                
            }
        }





    }
    /// <summary>
    /// 滑行
    /// </summary>
    private void Slide()
    {
        bool down = Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S);
        ani.SetBool("side switch", down);
        if(Input.GetKeyDown(KeyCode.DownArrow))  aud.PlayOneShot(soundSlide, 05f);
            
        if (down)
        {
            cap.offset = new Vector2(-0.05f, -0.5f);
            cap.size = new Vector2(1f, 2f);
            

        }
        else
        {
            cap.offset = new Vector2(-0f, -0f);
            cap.size = new Vector2(2f, 4f);
        }
        //X-0.05 Y-0.07 Size X 2 y 3.8

    }
    /// <summary>
    /// 吃金幣
    /// </summary>
    private void EatCoin(GameObject obj)
    {
        coin++;
        aud.PlayOneShot(soundCoin, 0.5f);
        textcoin.text = "金幣數量" + coin;
        Destroy(obj,0.1f);//0.1秒後消失
    }
    /// <summary>
    /// 受傷
    /// </summary>
    private void Hit(GameObject obj)
    {
        hp -= 30;
        aud.PlayOneShot(soundHit);
        Destroy(obj);

        imageHp.fillAmount = hp / hpMax;

        if (hp <= 0) Dead();
    }


    /// <summary>
    /// 死亡
    /// </summary>
    private void Dead()
    {
        ani.SetTrigger("dead");
        final.SetActive(true);
        textTitle.text = "死掉嘞~!";
        textFinalCoin.text = "本次金幣數量" + coin;

        dead = true;
    }
    [Header("過關標題與金幣")]
    public Text textTitle;
    public Text textFinalCoin;

    /// <summary>
    /// 通關
    /// </summary>
    private void Pass()
    {
        speed = 0;
        final.SetActive(true);
        textTitle.text = "您贏勒~!";
        textFinalCoin.text = "本次金幣數量" + coin;
    }

    #endregion

    #region 事件
    private void Start()
    {
        hpMax = hp;
    }
    private void Update()
    {
        if (dead) return;//如果死亡就跳出
        if (transform.position.y <= -5) Dead();
        Jump();
        Slide();
        Move();
    }
    //碰撞事件  必須有一個is Trigger
    //Enter進入時   Stay碰撞時持續   Exit 離開時
    //參數:紀錄碰撞資訊
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //碰撞到金幣 並把金避碰撞資訊傳回 
        if (collision.tag == "coin") EatCoin(collision.gameObject);

        if (collision.tag == "enemy") Hit(collision.gameObject);

        if (collision.tag == "pass") Pass();
    }

    //繪製圖示事件:僅在Scene看得到
   /* private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        //transform.up上方       Y
        //transform.right右方    X
        //transform.forward前方  Z
        Gizmos.DrawRay(transform.position + new Vector3(0, -0.8f), -transform.up * 0.01f);
    }*/
    #endregion
}
