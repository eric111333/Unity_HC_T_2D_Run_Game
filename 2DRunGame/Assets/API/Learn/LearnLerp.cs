using UnityEngine;

public class LearnLerp : MonoBehaviour
{
    public float A = 0;
    public float B = 111;

    private void Start()
    {
        float result = Mathf.Lerp(A, B, 0.5f);
        print(result);
    }
    public float C = 0;
    public float D = 100;

    public Vector2 v2A = new Vector2(0, 0);
    public Vector2 v2B = new Vector2(1000, 1000);

    private void Update()
    {

    }
}
