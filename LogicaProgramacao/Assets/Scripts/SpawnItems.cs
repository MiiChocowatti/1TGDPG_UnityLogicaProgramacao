using System.Collections;
using UnityEngine;
using UnityEngine.Rendering;

public class SpawnItems : MonoBehaviour
{
    [SerializeField] private float upLimit, downLimit, leftLimit, rightLimit;
    [SerializeField] private GameObject coinPrefab;
    [SerializeField] private float timeToSpawn;
    void Start()
    {
        StartCoroutine(Spawn(timeToSpawn));
    }

    IEnumerator Spawn(float t)
    {
        yield return new WaitForSeconds(t);

        Vector2 p = new Vector2(Random.Range(leftLimit, rightLimit), Random.Range(upLimit, downLimit));

        Destroy(Instantiate(coinPrefab, p, transform.rotation), 3.0f);

        StartCoroutine(Spawn(t));
    }
    void Update()
    {
        
    }
}
