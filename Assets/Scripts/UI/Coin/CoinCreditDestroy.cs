
using UnityEngine;

public class CoinCreditDestroy : MonoBehaviour
{
private float posY;
    private void Update() {
        posY = transform.position.y;
        if (posY < - 8.0f) {
            Destroy(gameObject);
        }
    }
    
}
