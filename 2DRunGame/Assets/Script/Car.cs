using UnityEngine;

public class Car : MonoBehaviour
{
    //資料
   // string brand;
   // int cc;
  //  float weight;
  //  bool window;
  //  float speed;
    //命名規則
    //不允許
    //1.特殊符號2.數字開頭3.保留字
    //允許
    //1.底線2.數字非開頭3.中文
    [Header("品牌")]
    public string brand = "賓士";
    [Header ("CC 數"),Tooltip("汽車的CC數量")]
    public  int cc = 1500;
    [Header("重量"), Range(0, 100)]
    public float weight = 20.5f;
    [Header("是否有天窗"), Tooltip("打勾代表有, 取消代表沒有")]
    public bool window = true;
    [Header("速度"), Range(0, 200)]
    public float speed = 60.5f;
    //顏色 座標(2.3.4)
    public Color red = Color.red;
    public Color mycolor = new Color(0.5f, 0.5f, 0.9f);
    public Vector2 posZero = Vector2.zero;
    public Vector2 posone = Vector2.one;
    public Vector2 posCustom = new Vector2(9, 20);
    public Vector3 pos3 = new Vector3(3, 2, 1);
    public Vector4 pos4 = new Vector4(1, 2, 3, 4);



    //物件:階層(Hierarchy)面板內的所有東西
    //元件:屬性(Inspector)面板內的粗體字>Class
    public GameObject cam;
    public Transform traCam;
    public Camera cam1;











}
