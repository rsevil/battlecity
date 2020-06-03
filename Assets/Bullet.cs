using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed;
    
    private Rigidbody2D _rigidBody;
    
    void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        _rigidBody.velocity = transform.up * speed;
    }
}
