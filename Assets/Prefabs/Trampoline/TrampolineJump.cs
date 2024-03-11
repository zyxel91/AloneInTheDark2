using UnityEngine;
using UnityEngine.UI;

public class TrampolineJump : MonoBehaviour
{
   public Rigidbody2D PlayerHere;
   public Animator anim;
   public GameObject textAct;
   public float speed = 24f;
     
     private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "Player" && ButtonTramp1.Button_1 == 0) {
            textAct.SetActive(true);
        }
        if(collision.gameObject.tag == "Player" && ButtonTramp1.Button_1 == 1) {
            anim.Play("JumpAnim");
            
            PlayerHere.AddForce((Vector2.up) * speed, ForceMode2D.Impulse);
            
        }
        
     }
     private void OnCollisionExit2D(Collision2D collision) {
        if(collision.gameObject.tag == "Player" && ButtonTramp1.Button_1 == 0) {
            textAct.SetActive(false);
        }
        if(collision.gameObject.tag == "Player" && ButtonTramp1.Button_1 == 1) {
                anim.Play("JumpAnimReturn");
        }
     }
}
