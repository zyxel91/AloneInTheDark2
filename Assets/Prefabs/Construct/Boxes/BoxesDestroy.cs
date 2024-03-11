
using Unity.VisualScripting;
using UnityEngine;

public class BoxesDestroy : MonoBehaviour
{
   private int boxLive = 0;
   public Animator _anim;
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Fire") {
            boxLive++;
        }
    }

    private void Update() {
        if (boxLive > 2) {
            _anim.Play("BoxDestroyAnim");
            Destroy(gameObject, 0.4f);
        }
    }
}
