using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;

    public Text coinText;
    int coins;

    public List<GameObject> enemiesInScreen;

    Enemy enemyScript = gameObject.GetComponent<Enemy>();
    
    public void GameOver()
    {
        isGameOver = true;
    }

    public void AddCoin()
    {
        coins++;
        coinText.text = coins.ToString();
    }

    foreach (enemy in enemiesInScreen)
    {
        enemyScript.OnBecameVisible();
    }
}
