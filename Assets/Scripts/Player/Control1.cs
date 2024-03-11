

using UnityEngine;

public class Control1 : MonoBehaviour
{
        public float speed = 5.0f;
        public Animator _anim;
        private Rigidbody2D rb;
        public SpriteRenderer sr;

    private void Awake() {
      _anim = gameObject.GetComponent<Animator>();
      rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
      //float h = Input.GetAxis("Horizontal");
      //sr.flipX = h < 0 ? true : false;
       //transform.Translate(new Vector2(1, 0) * speed * Time.deltaTime * h);
      if(Input.GetKey(KeyCode.LeftArrow))
       transform.position += (new Vector3(1, 0, 0) * -speed * Time.deltaTime);
       if(Input.GetKey(KeyCode.RightArrow))
       transform.position += (new Vector3(1, 0, 0) * speed * Time.deltaTime);
       if (Input.GetKey(KeyCode.RightArrow)) {
         TakeObjects1.pos = Vector2.right;
         sr.flipX = false;
       }
       if (Input.GetKey(KeyCode.LeftArrow)) {
         TakeObjects1.pos = Vector2.left;
         sr.flipX = true;
       }
       
       if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow)) {
          _anim.SetInteger("walk" , 1);
       } else {
        _anim.SetInteger("walk" , 0);
       }
       if (Input.GetKey(KeyCode.UpArrow) && Mathf.Abs(rb.velocity.y) > 0.02f ) {
          _anim.SetInteger("jmp" , 1);
          _anim.SetInteger("jmpFrIdle" , 1);
       } else {
        _anim.SetInteger("jmpFrIdle" , 0);
        _anim.SetInteger("jmp" , 0);
       }
    }
    
}
  