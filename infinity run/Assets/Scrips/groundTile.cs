using UnityEngine;

public class groundTile : MonoBehaviour
{
    SpawnPiso groundSpawner;


    void Start()
    {
        groundSpawner = GameObject.FindAnyObjectByType<SpawnPiso>();
        SpawnObstacle();
        //SpawnMoneda();
    }
    private void OnTriggerEnter(Collider other)
    {
        groundSpawner.SpawnTile();
        Destroy(gameObject, 2);
    }

    void Update()
    {
        
    }
    public GameObject obstaculoPrefab;
    void SpawnObstacle()
    {
        int obstacleSpawnIndex = Random.Range(2, 5);
        Transform spawnpoint = transform.GetChild(obstacleSpawnIndex).transform;
        Instantiate(obstaculoPrefab, spawnpoint.position, Quaternion.identity, transform); 
    }
    public GameObject monedaPrefab;
    void SpawnMoneda()
    {
        int coinsToSpawn = 1;
        for(int i = 0; i < coinsToSpawn; i++)
        {
            GameObject temp = Instantiate(monedaPrefab, transform);
            temp.transform.position = GetRandomPointInCollider(GetComponent<Collider>());
        }

    }
    Vector3 GetRandomPointInCollider (Collider collider)
    {
        Vector3 point = new Vector3(
            Random.Range(collider.bounds.min.x, collider.bounds.max.x), Random.Range(collider.bounds.min.y, collider.bounds.max.y), Random.Range(collider.bounds.min.z, collider.bounds.max.z));
        if(point != collider.ClosestPoint(point))
        {
            point = GetRandomPointInCollider(collider);
        }
        point.y = 1;
        return point;
    }


}
