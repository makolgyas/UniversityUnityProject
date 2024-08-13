using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float playerHp = 10;
    public GameObject enemyVFXPrefab; // Prefаб для эффекта VFX

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            // Уменьшение здоровья игрока
            playerHp -= 10;

            // Воспроизведение эффекта VFX и удаление объекта
            Enemy enemy = other.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.PlayVFX();
                Destroy(other.gameObject);
            }
        }
    }
}


