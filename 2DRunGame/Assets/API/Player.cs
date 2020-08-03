﻿using UnityEngine;

public class Player : MonoBehaviour
{
    #region 欄位
    [Header("移動速度"),Range(0,1000)]
    public float speed = 5;
    [Header("跳躍高度"),Range(0,1000)]
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
    public Rigidbody2D rid;
    public CapsuleCollider2D cap;
    #endregion

    #region 方法
    /// <summary>
    /// 移動
    /// </summary>
    private void Move()
    {
        
    }
    /// <summary>
    /// 跳躍
    /// </summary>
    private void Jump()
    {
        bool space = Input.GetKeyDown(KeyCode.Space)||Input.GetKeyDown(KeyCode.UpArrow);
        //bool up = Input.GetKeyDown(KeyCode.UpArrow);
        ani.SetBool("jump switch", space);
    }
    /// <summary>
    /// 滑行
    /// </summary>
    private void Slide()
    {
        bool down = Input.GetKeyDown(KeyCode.DownArrow);
        
        if (down == true)
        {
            ani.SetBool("side switch", down);
        }
        else
        {

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
    }
    #endregion
}
