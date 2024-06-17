using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public int CoinAmount;
    public TMP_Text CoinsAmount;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        CoinsAmount.text = CoinAmount.ToString();
    }
}
