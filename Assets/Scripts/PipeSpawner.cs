using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] float maxTime = 1.5f;
    [SerializeField] private float heightRange = 0.45f;
    [SerializeField] GameObject pipe;

    float timer;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    private void Update()
    {
        if(timer > maxTime)
        {
            SpawnPipe();
            timer = 0;
        }
        timer += Time.deltaTime;
    }

    private void SpawnPipe()
    {
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-heightRange, heightRange));
        GameObject spawnPipe = Instantiate(pipe, spawnPos, Quaternion.identity);

        Destroy(spawnPipe, 10f);
    }
}
