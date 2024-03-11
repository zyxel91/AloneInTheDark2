using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheck : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;
    void Update()
    {
        if (MainMenu.onePlayer == true) {
            Player1.SetActive(false);
            Player2.SetActive(false);
        }
        if (MainMenu.twoPlayer == true) {
            
            Player2.SetActive(false);
        }
        Debug.Log(MainMenu.onePlayer);
    }
}
