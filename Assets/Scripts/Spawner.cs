using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject oilPrefab;
    public GameObject enemyPrefab;
    public float blockRate = 1f;
    private float nextSpawnTime;
    private float nextBlockTime;

    
    void Update()
    {
        if (Time.time > nextBlockTime)
        {
            SpawnBlock();
            nextBlockTime = Time.time + 1f / blockRate;
        }
    }
    void SpawnBlock()
    {
        float rand = Random.value;
        if (rand < 0.2f)
        {
            //Oil
            float randomXForOil = Random.Range(-3f, 3f);
            GameObject oil = Instantiate(oilPrefab, new Vector3(randomXForOil, 7, -1), Quaternion.identity);
        }
        else if(rand < 0.4f)
        {
            //Enemy
            float randomXForEnemy = Random.Range(-3f, 3f);
            GameObject enemy = Instantiate(enemyPrefab, new Vector3(randomXForEnemy, 7,-1), Quaternion.identity);
        }
        else
        {
            Debug.Log("안나옴");
        }
    }
}