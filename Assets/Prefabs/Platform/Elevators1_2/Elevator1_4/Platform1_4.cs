
using UnityEngine;

public class Platform1_4 : MonoBehaviour
{
   
    public Animator _anim;
    private bool platformUP = false;
    void Update()
    {
        if (switch1_4._Switch1_4 == 1) {
            
            Invoke("PlatformUP", 2f);
            platformUP = true;
        }
        if (switch1_4._Switch1_4 == 0 && platformUP == true) {
            
            Invoke("PlatformDOWN", 2f);
            platformUP = false;
        }
    }
    void PlatformUP(){  
_anim.Play("Platform1_1UP");
        }
        void PlatformDOWN(){
_anim.Play("Platform1_1DOWN");
        }
}
