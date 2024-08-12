using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinManager : MonoBehaviour
{

    public int totalCoin;
    public TMP_Text scoreText;
    
    public void IncreaseCoin(int amount)
    {
        totalCoin += amount;
        UpdateCoin();
    }

    private void UpdateCoin()
    {
        scoreText.text = totalCoin.ToString();
    }
}
