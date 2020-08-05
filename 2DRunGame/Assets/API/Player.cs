using UnityEngine;

public class Player : MonoBehaviour
{
    #region 欄位
    [Header("移動速度"), Range(0, 1000)]
    public float speed = 5;
    [Header("跳躍高度"), Range(0, 1000)]
    public int jump = 350;
    [Header("血量"), Range(0, 2000)]
    public float hp = 500;

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
        bool space = Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow);
        //bool up = Input.GetKeyDown(KeyCode.UpArrow);
        RaycastHit2D hit = Physics2D.Raycast(transform.position + new Vector3(0, -0.8f), -transform.up, 0.01f, 1 << 8);
        if (hit)
        {
            isGround = true;
            ani.SetBool("jump switch", false);
        }
        else
        {
            isGround = false;
        }

        if (isGround)
        {
            if (space)
            {
                ani.SetBool("jump switch", true);
                rig.AddForce(new Vector2(0, jump));
                aud.PlayOneShot(soundJump, 05f);
                
            }
        }





    }
    /// <summary>
    /// 滑行
    /// </summary>
    private void Slide()
    {
        bool down = Input.GetKey(KeyCode.DownArrow);
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
    private void EatCoin()
    {

    }
    /// <summary>
    /// 受傷
    /// </summary>
    private void Hit()
    {

    }
    /// <summary>
    /// 死亡
    /// </summary>
    private void Dead()
    {

    }
    /// <summary>
    /// 通關
    /// </summary>
    private void Pass()
    {

    }

    #endregion

    #region 事件
    private void Start()
    {

    }
    private void Update()
    {
        Jump();
        Slide();
        Move();
    }
    //繪製圖示事件:僅在Scene看得到
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        //transform.up上方       Y
        //transform.right右方    X
        //transform.forward前方  Z
        Gizmos.DrawRay(transform.position + new Vector3(0, -0.8f), -transform.up * 0.01f);
    }
    #endregion
}
