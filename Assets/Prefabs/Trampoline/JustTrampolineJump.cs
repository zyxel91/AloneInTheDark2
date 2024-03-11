using UnityEngine;

public class JustTrampolineJump : MonoBehaviour
{
   public Rigidbody2D PlayerHere;
   public Animator anim;
   public float speed = 24f;
     
     private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "Player") {
            anim.Play("JumpAnim");
            PlayerHere.AddForce((Vector2.up) * speed, ForceMode2D.Impulse);
        }
     }
     private void OnCollisionExit2D(Collision2D collision) {
        if(collision.gameObject.tag == "Player") {
                anim.Play("JumpAnimReturn");
        }
     }
}
