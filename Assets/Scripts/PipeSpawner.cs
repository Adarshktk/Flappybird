using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject pipePrefab;
    [SerializeField] private float maxTimer = 5f;
    [SerializeField] private float heightRange = .7f;
    [SerializeField] private float pipeDestroyTimer = 10f;

    private float timer;

    private void Start()
    {
        SpawnPipe();
    }

    private void Update()
    {
        if(timer > maxTimer)
        {
            SpawnPipe();
            timer = 0f;

        }
        timer += Time.deltaTime;
    }

    private void SpawnPipe()
    {
        Vector3 spawnPosition = transform.position + new Vector3(0, (Random.Range(-heightRange, heightRange)));
        GameObject pipe = Instantiate(pipePrefab, spawnPosition, Quaternion.identity);
        Destroy(pipe, pipeDestroyTimer);
    }
}
