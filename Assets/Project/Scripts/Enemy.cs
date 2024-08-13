using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject enemyVFXPrefab; // Префаб для эффекта VFX

    // Метод для воспроизведения VFX
    public void PlayVFX()
    {
        if (enemyVFXPrefab != null)
        {
            Instantiate(enemyVFXPrefab, transform.position, Quaternion.identity);
        }
    }

    // Метод вызывается при удалении объекта
    private void OnDestroy()
    {
        // Воспроизведение эффекта VFX при удалении объекта
        PlayVFX();
    }
}

