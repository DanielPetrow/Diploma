using UnityEngine;
using System.Collections.Generic;

public class MenuPrefabSpawner : MonoBehaviour
{
    public List<GameObject> _menuPrefabs;

    public float _minSpawnDelay = 5f;
    public float _maxSpawnDelay = 8f;
    public float _spawnXLimit = 150f;

    private float random;

    private GameObject prefab;

    private Vector3 spawnPos;

    private void Start()
    {
        Spawn();
    }

    private void Spawn()
    {
        random = Random.Range(-_spawnXLimit, _spawnXLimit);
        spawnPos = new Vector3(random, -120f, 150f);
        prefab = _menuPrefabs[Random.Range(0, 47)];
        prefab.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);

        Instantiate(prefab, spawnPos, Quaternion.identity);

        Invoke("Spawn", Random.Range(_minSpawnDelay, _maxSpawnDelay));
    }
}
