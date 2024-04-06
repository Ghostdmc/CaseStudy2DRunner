
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] platformPrefabs;
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
            SpawnPlatform();
            lastSpawnPositionX += spawnOffset;
        }


        if (playerTransform.position.x - destroyOffset > lastDestroyPositionX)
        {
            DestroyPlatform();
            lastDestroyPositionX += destroyOffset;
        }
    }

    private void SpawnPlatform()
    {
        int randIndex = Random.Range(0, platformPrefabs.Length);
        Instantiate(platformPrefabs[randIndex], spawnPoint.position + Vector3.right * lastSpawnPositionX, Quaternion.identity);
    }

    private void DestroyPlatform()
    {

        GameObject[] platforms = GameObject.FindGameObjectsWithTag("Platform");
        if (platforms.Length > 0)
        {
            Destroy(platforms[0]);
        }
    }
}
