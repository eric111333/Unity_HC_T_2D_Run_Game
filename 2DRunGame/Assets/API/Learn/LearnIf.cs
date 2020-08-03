using UnityEngine;

public class LearnIf : MonoBehaviour
{

    void Start()
    {
        if (true)
        {
            print("我是判斷式");
        }
        
    }

    public bool open;

    public int score = 100;
    void Update()
    {
        if(open)
        {
            print("開門");
        }
        else
        {
            print("關門");
        }

        if (score >= 60) 
        {
            print("及格");
        }
        else if (score >= 40)
        {
            print("參予補考");
        }
        else
        {
            print("GG");
        }


    }
}
