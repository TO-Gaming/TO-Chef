using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectspawner : MonoBehaviour
{
    public GameObject[] Lemons;
    public Transform SpawnPoint;
    public float IntervalSpawn;
    [SerializeField]
    public float border = 1f;

    private float spawnBetweenTime;
    

    // Update is called once per frame
    void FixedUpdate()
    {
        if (spawnBetweenTime <= 0)
        {
            int rand = Random.Range(0, Lemons.Length);
            Vector3 positionOfSpawnedObject = new Vector3(
                transform.position.x ,
                transform.position.y ,
                transform.position.z + Random.Range(-border, +border));
            SpawnPoint.position = positionOfSpawnedObject;
            Instantiate(Lemons[rand],SpawnPoint.position, Quaternion.identity);
            spawnBetweenTime = IntervalSpawn; // charge var with value
        }
        else
        {
            spawnBetweenTime -= Time.deltaTime;
        }
    }
}
