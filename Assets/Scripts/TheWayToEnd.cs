
using UnityEngine;

public class TheWayToEnd : MonoBehaviour
{
    public GameObject Enemy;
    void Update()
    {
        if (Enemy == null) {
            Destroy(gameObject);
        }
    }
}
