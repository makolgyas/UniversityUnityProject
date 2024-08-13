using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float playerHp = 10;
    public GameObject enemyVFXPrefab; // Pref�� ��� ������� VFX

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            // ���������� �������� ������
            playerHp -= 10;

            // ��������������� ������� VFX � �������� �������
            Enemy enemy = other.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.PlayVFX();
                Destroy(other.gameObject);
            }
        }
    }
}


