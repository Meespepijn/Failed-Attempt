using UnityEditor.Rendering;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public Rigidbody2D playerRb;
    public float playerSpeed = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            playerRb.AddForce(Vector2.up * playerSpeed, ForceMode2D.Impulse);
        }
    
    }
}
