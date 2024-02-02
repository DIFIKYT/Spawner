using UnityEngine;

public class EnemyDestroyer : MonoBehaviour
{
    [SerializeField] private float _destroyDelay = 5f;

    void Start()
    {
        Invoke(nameof(DestroyEnemy), _destroyDelay);
    }

    private void DestroyEnemy()
    {
        Destroy(gameObject);
    }
}