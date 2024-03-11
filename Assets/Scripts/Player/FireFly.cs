
using UnityEngine;

public class FireFly : MonoBehaviour
{
   public float speed = 7.0f;
    void Start()
    {
        
    }

    private void Update()
    {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

private void OnCollisionEnter2D(Collision2D collision) {
    if (collision.gameObject.tag == "Player") {
        gameObject.GetComponent<CircleCollider2D>().isTrigger = true;
        }
    else {Destroy(gameObject);}
}
private void OnTriggerExit2D(Collider2D collider) {
        gameObject.GetComponent<CircleCollider2D>().isTrigger = false;
    
}
}
 