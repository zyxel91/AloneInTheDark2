using UnityEngine;

public class MainPlatform : MonoBehaviour
{
    public Animator anim;
    void Start()
    {
        
    }

    void Update()
    {
        // Debug.Log("m " + MainSwitch2_0.MainSwitch);
        // Debug.Log("1 " + switch2_1._Switch2_1);
        // Debug.Log("2 " + switch2_2._Switch2_2);
        // Debug.Log("3 " + switch2_3._Switch2_3);
        // Debug.Log("4 " + switch2_4._Switch2_4);
        // Debug.Log("5 " + switch2_5._Switch2_5);
        // Debug.Log("6 " + switch2_6._Switch2_6);
        // Debug.Log("7 " + switch2_7._Switch2_7);
        // Debug.Log("8 " + switch2_8._Switch2_8);
        // Debug.Log("9 " + switch2_9._Switch2_9);
        if (MainSwitch2_0.MainSwitch == 1) {
            anim.Play("Platform2_0DOWN");
        }
        if (switch2_6._Switch2_6 == 1) {
            anim.Play("Platform2_0DOWN2");
        }
        if (switch2_7._Switch2_7 == 1) {
            anim.Play("Platform2_0DOWN3");
        }
        if (switch2_8._Switch2_8 == 1) {
            anim.Play("Platform2_0DOWN4");
            switch2_8._Switch2_8 = 0;
        }
        if (switch2_9._Switch2_9 == 1) {
            anim.Play("Platform2_0DOWN5");
            switch2_9._Switch2_9 = 0;
        }
    }
}
