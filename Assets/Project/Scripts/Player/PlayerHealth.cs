using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float playerHp = 10;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            playerHp -= 10;
            playerHp = playerHp - 10;
        }
    }
}
