using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateSpawner : MonoBehaviour
{
    public GameObject cratePrefab;

    public int amountofCrateToSpawn;





    // Update is called once per frame
    private void Start()

    {
        for (int i = 0; i < amountofCrateToSpawn; i++) { 


        Instantiate(cratePrefab, transform.localPosition, Quaternion.identity, this.transform); }
    }
}
