using UnityEngine;

public class TileSpawn : MonoBehaviour
{
    public GameObject roadTilePrefab;
    public float spawnRate = 1f;
    private float nextSpawnTime;
    public float fallSpeed = 2f;

    
    void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            SpawnRoadTile();
            nextSpawnTime = Time.time + 1f / spawnRate;
        }
    }
    void SpawnRoadTile()
    {
        GameObject roadTile = Instantiate(roadTilePrefab, new Vector3(0, 6, 0), Quaternion.identity);
        roadTile.AddComponent<RoadTileFall>();
        roadTile.GetComponent<RoadTileFall>().fallSpeed = fallSpeed;
    }
}
public class RoadTileFall : MonoBehaviour
{
    public float fallSpeed;
    void Update()
    {
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);
        if (transform.position.y < -6)
        {
            Destroy(gameObject);
        }
        
    }
    
}
