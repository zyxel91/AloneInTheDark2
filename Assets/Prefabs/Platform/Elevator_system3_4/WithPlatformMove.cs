
using UnityEngine;

public class WithPlatformMove : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col) {
        col.gameObject.transform.SetParent(gameObject.transform);
    }
    private void OnTriggerExit2D(Collider2D col) {
        col.gameObject.transform.SetParent(null);
    }
}
