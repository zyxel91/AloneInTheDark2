
using UnityEngine;

public class DRLEnemyTriggerFire : MonoBehaviour
{
    public GameObject _enimy;
    private void OnTriggerStay2D(Collider2D other) {
        if (_enimy == null)
        {} else 
        if (other.gameObject.name == "chick") {
            _enimy.GetComponent<DRLEnemyShoot>().Shoot();
        }
    }
}