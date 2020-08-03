using UnityEngine;

public class LearnAPI : MonoBehaviour
{
    public GameObject sphere;
    public Transform tra;
    public Transform cube;
    public Light mylight;
    public Camera cam;

    void Start()
    {
        print(sphere.layer);
        print("球的座標" + tra.position);
        tra.localScale = new Vector3(9, 9, 9);

        //mylight.color = Color.red;
        mylight.color = new Color(0.8f, 0, 0);
        mylight.Reset();

        cam.orthographicSize = 3;


        
    }

    void Update()
    {
        cube.Rotate(0, 0, 5);
        cube.Translate(0.5f, 0, 0);
    }
}
