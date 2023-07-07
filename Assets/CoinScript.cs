using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Feedbacks;
using GrimoireScripts;

public class CoinScript : MonoBehaviour
{
    private MMFeedbacks coinFeedbacks;

    void Start()
    {
        coinFeedbacks = GetComponent<MMFeedbacks>();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            print("Player touched the coin");
            other.gameObject.GetComponent<Inventory>().addMoney(15);
            coinFeedbacks.PlayFeedbacks();
        }
    }
}
