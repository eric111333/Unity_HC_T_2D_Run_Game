using UnityEngine;

public class LearnAPIStatic : MonoBehaviour
{
   //認識API內有靜態(Static)關鍵字成員
    void Start()
    {
        //取得靜態屬性 Static Properties
        //語法:類別,靜態屬性
        print(Random.value);
        print(Mathf.PI);
        float r = Random.Range(100, 200);
        print("隨機直" + r);
        int ri = Random.Range(1, 3);
        print("隨機整數" + ri);
        //隱藏滑鼠
        Cursor.visible = false;
        print("-9的絕對值" + Mathf.Abs(-9));



    }

 
    void Update()
    {
        // print("遊戲時間" + Time.time);
        print("玩家按任意件" + Input.anyKeyDown);
    }
}
