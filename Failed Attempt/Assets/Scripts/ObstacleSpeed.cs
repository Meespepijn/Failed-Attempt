using UnityEngine;

public class ObstacleSpeed : MonoBehaviour
{
    public float obstacleSpeed = 5;
    public float speedIncrease = 0.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        obstacleSpeed += Time.deltaTime * speedIncrease;
        transform.Translate(Vector2.left * obstacleSpeed * Time.deltaTime);
    }
}
