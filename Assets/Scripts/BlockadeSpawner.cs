
using UnityEngine;

public class BlockadeSpawner : MonoBehaviour
{
    public GameObject[] blockadePrefabs;
    public Transform playerTransform;
    public Transform spawnPoint;
    public float spawnOffset = 10f;
    public float destroyOffset = 10f;
    private float lastSpawnPositionX = 0f;
    private float lastDestroyPositionX = 0f;

    private void Update()
    {

        if (playerTransform.position.x + spawnOffset > lastSpawnPositionX)
        {
            SpawnBlockade();
            lastSpawnPositionX += spawnOffset;
        }


        if (playerTransform.position.x - destroyOffset > lastDestroyPositionX)
        {
            DestroyBlockade();
            lastDestroyPositionX += destroyOffset;
        }
    }

    private void SpawnBlockade()
    {
        int randIndex = Random.Range(0, blockadePrefabs.Length);
        Instantiate(blockadePrefabs[randIndex], spawnPoint.position + Vector3.right * lastSpawnPositionX, Quaternion.identity);
    }

    private void DestroyBlockade()
    {

        GameObject[] blockades = GameObject.FindGameObjectsWithTag("Blockade");
        if (blockades.Length > 0)
        {
            Destroy(blockades[0]);
        }
    }
}
