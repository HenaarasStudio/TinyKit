using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(Collider))]
[RequireComponent(typeof(Rigidbody))]
[AddComponentMenu("TinyKit/3D Control")]
public class Control3D : MonoBehaviour
{
    
    [Header("Control Settings")]
    [Range(0f, 15f)]
    public float speed = 2f;

    [Header("Control Axis")]
    public bool x = true;
    public bool z = false;

    [Header("Jump")]
    public bool canJump = true;
    [Range(0f, 10f)]
    public float jumpSpeed = 2f;

    public float asd;

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
            float v_input = Input.GetAxis("Vertical");

            float x_move = 0;
            float y_move = 0;
            float z_move = 0;

            if (x && h_input != 0)
            {
                x_move = speed * h_input * Time.deltaTime;
            }

            if (z && v_input != 0)
            {
                z_move = speed * v_input * Time.deltaTime;
            }

            transform.Translate(x_move, y_move, z_move);
        }   
    }
}
