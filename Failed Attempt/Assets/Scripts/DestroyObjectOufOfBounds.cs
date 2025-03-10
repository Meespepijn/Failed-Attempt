using UnityEngine;

public class DestroyObjectOufOfBounds : MonoBehaviour
{
    public float leftBounds;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < leftBounds)
        {
            Destroy(gameObject);
        }
    }
}
