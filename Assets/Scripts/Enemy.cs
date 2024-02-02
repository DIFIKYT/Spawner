using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    [SerializeField] private float _destroyDelay = 5f;

    private void Start()
    {
        Invoke(nameof(DestroyEnemy), _destroyDelay);
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }

    private void DestroyEnemy()
    {
        Destroy(gameObject);
    }
}