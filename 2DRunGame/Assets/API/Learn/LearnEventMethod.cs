using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnEventMethod : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        print("哈囉.沃德~~");
        Drive(125, "右邊");
        Drive();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //參數預設值：選填式參數
    //語法：類型 名稱 = 值

    public void Drive(int speed = 0, string direction = "前方",string sound = "咻咻")
    {
        print("時速：" + speed);
        print("開車方向：" + direction);
        print("開車音效：" + sound);

    }





}
