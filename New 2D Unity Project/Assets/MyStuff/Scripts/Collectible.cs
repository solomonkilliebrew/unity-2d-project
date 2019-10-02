using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;
public class Collectible : MonoBehaviour
{
    private bool _hasbeenCollected = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!_hasbeenCollected && collision.gameObject.GetComponent<PlatformerCharacter2D>())
        {
            HandleCollected();
        }
    }

    void HandleCollected()
    {
         
        _hasbeenCollected = true;
        CollectibleManager.Instance.HandleCoinCollected();
        Destroy(gameObject);
    }
}
