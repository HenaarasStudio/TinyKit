using UnityEditor;
using UnityEngine;

[RequireComponent (typeof(Collider2D))]
[RequireComponent (typeof(Rigidbody2D))]
[AddComponentMenu("TinyKit/2D Control")]
public class Control2D : MonoBehaviour
{
    
    [Header("Control Settings")]
    [Range(0f, 15f)]
    public float speed = 2f;

    [Header("Jump")]
    public bool canJump = true;
    [Range(0f, 10f)]
    public float jumpSpeed = 2f;

    void Start()
    {
        if (gameObject.tag == "Untagged")
        {
            gameObject.tag = "Control";
        }
    }

    void Update()
    {
        if (Input.anyKey)
        {
            float h_input = Input.GetAxis("Horizontal");

            float x_move = 0;
            float y_move = 0;
            float z_move = 0;

            if (h_input != 0)
            {
                x_move = speed * h_input * Time.deltaTime;
            }

            transform.Translate(x_move, y_move, z_move);
        }   
    }
}
