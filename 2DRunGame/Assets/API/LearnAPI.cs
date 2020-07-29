using UnityEngine;

public class LearnAPI : MonoBehaviour
{
    public GameObject sphere;
    public Transform tra;
    public Transform cube;
    public Light light;

    void Start()
    {
        print(sphere.layer);
        print("球的座標" + tra.position);
        tra.localScale = new Vector3(9, 9, 9);

        
    }

    void Update()
    {
        cube.Rotate(0, 0, 5);
        cube.Translate(0.5f, 0, 0);
    }
}
