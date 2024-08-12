using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpManager : MonoBehaviour
{
    public bool isIncrease;
    public CoinManager coinManager;
    public int amount;

    private void Start()
    {
        coinManager = FindObjectOfType<CoinManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isIncrease)
        {
            coinManager.IncreaseCoin(amount);
        }

        gameObject.SetActive(false);
    }
}
