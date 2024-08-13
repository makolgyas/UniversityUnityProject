using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject enemyVFXPrefab; // ������ ��� ������� VFX

    // ����� ��� ��������������� VFX
    public void PlayVFX()
    {
        if (enemyVFXPrefab != null)
        {
            Instantiate(enemyVFXPrefab, transform.position, Quaternion.identity);
        }
    }

    // ����� ���������� ��� �������� �������
    private void OnDestroy()
    {
        // ��������������� ������� VFX ��� �������� �������
        PlayVFX();
    }
}

