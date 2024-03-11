using UnityEngine;

public class TakeObjects1 : MonoBehaviour
{
    public bool hold;
    public float distance = 0.5f;
    RaycastHit2D hit;
    public Transform holdPoint;
    public Transform holdPointLeft;
    public float throwObject = 1f;
    public static Vector2 pos; //для смены навправления вектора в Control
    //private Rigidbody2D rb;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L)) {
            if (!hold) {
                Physics2D.queriesStartInColliders = false;
                hit = Physics2D.Raycast(transform.position, pos * transform.localScale.x, distance);

                if (hit.collider != null && hit.collider.tag == "TakeObject") {
                    hold = true;
                }
            }
            else {
                hold = false;
                if (hit.collider.gameObject.GetComponent<Rigidbody2D>() != null && pos == Vector2.right) {
                    hit.collider.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(transform.localScale.x, 2) * throwObject;
                }
                if (hit.collider.gameObject.GetComponent<Rigidbody2D>() != null && pos == Vector2.left) {
                    hit.collider.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(transform.localScale.x, 2) * -throwObject;
                }
            }
        }
        if (hold && pos == Vector2.right) {
           hit.collider.gameObject.transform.position = holdPoint.position;
        }
         if (hold && pos == Vector2.left) {
           hit.collider.gameObject.transform.position = holdPointLeft.position;
        }
    }
    private void OnDrawGizmos() {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.right * transform.localScale.x * distance);

    }
}
