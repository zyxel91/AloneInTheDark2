using UnityEngine;

public class Platform3_3 : MonoBehaviour
{
    public Animator _anim;
    void Update()
    {
        if (Switch3_3._Switch3_3 == 1) {
            _anim.Play("3Platform3_3Down");
        }
        if (Switch3_3._Switch3_3 == 0) {
            _anim.Play("3Platform3_3Up");
        }
    }
}
