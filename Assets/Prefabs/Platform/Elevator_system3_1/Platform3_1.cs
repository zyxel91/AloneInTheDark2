
using System.Diagnostics;
using UnityEngine;

public class Platform3_1 : MonoBehaviour
{
    public Animator _anim;
    void Update()
    {
        if (Switch3_1._Switch3_1 == 1) {
            _anim.Play("1_Platform_Down1");
        }
        if (Switch3_1._Switch3_1 == 0) {
            _anim.Play("1_Platform_Up1");
        }
    }
}
