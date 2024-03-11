
using UnityEngine;

public class TakeText : MonoBehaviour
{
    public GameObject takeMessage;
    
    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "Player") {
            takeMessage.SetActive(true);
        }
    }
    private void OnCollisionExit2D(Collision2D collision) {
        if(collision.gameObject.tag == "Player") {
            takeMessage.SetActive(false);
        }
    }
}
