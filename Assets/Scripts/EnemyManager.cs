using System;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float enemySpeed;
    public float zBoundary;
    public float spawnTime;
    public Transform RedSpawn;
    public Transform BlueSpawn;
    public Transform GreenSpawn;
    public Transform YellowSpawn;
    public Material RedMaterial;
    public Material BlueMaterial;
    public Material GreenMaterial;
    public Material YellowMaterial;

    float _timeSinceLastSpawn = 0f;

    void Update()
    {
        _timeSinceLastSpawn += Time.deltaTime;
        if (_timeSinceLastSpawn > spawnTime)
        {
            _timeSinceLastSpawn = 0f;
            SpawnEnemy();
        }
    }

    private void SpawnEnemy()
    {
        var newBlock = Instantiate(enemyPrefab);
        var enemyController = newBlock.GetComponent<EnemyController>();
        var enemyMesh = newBlock.GetComponent<MeshRenderer>();
        enemyController.speed = enemySpeed;
        enemyController.zBoundary = zBoundary;
        var choice = UnityEngine.Random.Range(0, 4);
        switch (choice)
        {
            case 0: // Red
                enemyMesh.material = RedMaterial;
                newBlock.transform.position = RedSpawn.position;
                break;
            case 1: // Blue
                enemyMesh.material = BlueMaterial;
                newBlock.transform.position = BlueSpawn.position;
                break;
            case 2: // Green
                enemyMesh.material = GreenMaterial;
                newBlock.transform.position = GreenSpawn.position;
                break;
            case 3: // Yellow
                enemyMesh.material = YellowMaterial;
                newBlock.transform.position = YellowSpawn.position;
                break;
            default:
                break;
        }
    }
}
