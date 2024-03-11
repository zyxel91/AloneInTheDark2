
using UnityEngine;

public class Booster : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider) {
        if(collider.gameObject.tag == "Player") {
            Fire.FireNum = 25;
            Fire.TimeNum = 1f;
            Destroy(gameObject);
        }
    }
}
