
using UnityEngine;

public class Jump1 : MonoBehaviour
{
    // public bool isGround;
    public float jumpForce = 5.0f;
    private Rigidbody2D rb;
    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }
    // private void OnCollisionEnter2D() {
    //     isGround = true;        

    // }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && Mathf.Abs(rb.velocity.y) < 0.02f)
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
    }
//     void Update()
//     {
//        if(Input.GetKeyDown(KeyCode.Space) && isGround) {
//         isGround = false;
//         rb.AddForce(new Vector2(0, jmp), ForceMode2D.Impulse);
//         } 
//     }
}

