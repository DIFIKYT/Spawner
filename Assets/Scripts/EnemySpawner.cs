using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _spawnInterval = 2f;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), 0f, _spawnInterval);
    }

    private void SpawnEnemy()
    {
        int randomSpawnPointIndex = Random.Range(0, _spawnPoints.Length);
        Transform spawnPoint = _spawnPoints[randomSpawnPointIndex];
        GameObject enemy = Instantiate(_enemyPrefab, spawnPoint.position, spawnPoint.rotation);
        Enemy enemyScript = enemy.GetComponent<Enemy>();

        if (enemyScript != null)
            enemyScript.transform.forward = spawnPoint.right;
    }
}