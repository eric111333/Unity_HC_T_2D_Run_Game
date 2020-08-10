using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Enemy01 : MonoBehaviour
{
    [Header("移動速度"), Range(0, 100)]
    public float speed = 10;
    private SpriteRenderer sprPlayer;
    private void Move()
    {
         float y = Mathf.Sin(Time.time) * Random.Range(-6,6) * Time.deltaTime;
         transform.Translate(y,0 , 0);
        

        /*if (gameObject.transform.position.x <= 8)
        {
            transform.Translate(speed * 1 * Time.deltaTime, 0, 0);
            sprPlayer.flipX = false;
        }
        else if (gameObject.transform.position.x >= -8)
        {   
            transform.Translate(speed * -1 * Time.deltaTime, 0, 0);
            sprPlayer.flipX = true;
        }*/

    }


    //aniPlayer.SetBool("run", h != 0);

    ///    //AD左右鍵翻轉
    ///    if (Input.GetKeyDown(KeyCode.A))
    ///    {
    //        sprPlayer.flipX = true;
    //    }
    //    if (Input.GetKeyDown(KeyCode.D))
    //    {
    //        sprPlayer.flipX = false;
    //   }
    //   if (Input.GetKeyDown(KeyCode.LeftArrow))
    //    {
    //       sprPlayer.flipX = true;
    //    }
    //    if (Input.GetKeyDown(KeyCode.RightArrow))
    //    {
    //        sprPlayer.flipX = false;
    //    }

    void Start()
    {
        sprPlayer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Move();
    }
}
