using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [Header("目標追蹤物")]
    public Transform target;
    [Header("追蹤速度"), Range(0, 100)]
    public float speed = 1;
    //上下限1.3  -0.5
    [Header("攝影機拍攝的上下限")]
    public Vector2 limit = new Vector2(0, 1.3f);


    /// <summary>
    /// 追蹤
    /// </summary>
    public void Track()
    {
        Vector3 posA = transform.position;
        Vector3 posB = target.position;

        posB.z = -10;

        posB.y = Mathf.Clamp(posB.y, limit.x, limit.y);      //Y軸 = 數學.夾住(限制Y軸上下限)

        posA = Vector3.Lerp(posA, posB, speed * Time.deltaTime);

        transform.position = posA;
    }

    void Start()
    {
        
    }


    void Update()
    {
        Track();
    }
}
