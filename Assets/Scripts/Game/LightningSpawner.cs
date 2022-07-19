using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningSpawner : MonoBehaviour
{
    public GameObject Lightnings;

    void Start()
    {
        StartCoroutine(Spawner());  
    }

    IEnumerator Spawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.5f);
            float random = Random.Range(0f, 2.9f);
            GameObject newLightnings = Instantiate(Lightnings, new Vector3(3, random, 0), Quaternion.identity);
            Destroy(newLightnings, 5);
        }
    }
}
