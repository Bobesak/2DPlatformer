using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinTrigger : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponentInParent<Coins>().CoinAmount++;
        gameObject.SetActive(false);

    }
    // Update is called once per frame

}
