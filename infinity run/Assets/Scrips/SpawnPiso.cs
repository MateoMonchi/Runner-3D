
using UnityEngine;

public class SpawnPiso : MonoBehaviour
{
    public GameObject GroundTile;
    Vector3 nextSpawnPoint;
   public float spawnTime;

    public void SpawnTile()
    {
       GameObject temp = Instantiate(GroundTile,nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }
   private void Start()
    {
        InvokeRepeating("SpawnTile",0f,spawnTime);
       
    }



}
