using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
	public GameObject coinPoof;

    public void OnCoinClicked() {
		//Instantiate the coinPoof prefab and destroy the coin
		Instantiate(coinPoof, transform.position, Quaternion.Euler(270, 0, 0));
		Destroy (gameObject);
    }
}
