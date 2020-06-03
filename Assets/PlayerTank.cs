using UnityEngine;

public class PlayerTank : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletSpawn;
    
    private Rigidbody2D _rigidBody;
    private bool wasMovingHorizontally = false;
    private bool wasMovingVertically = false;

    // Start is called before the first frame update
    void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation);
        }
    }

    private void FixedUpdate()
    {
        var x = 0;
        var y = 0;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            y = 1;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            y = -1;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            x = -1;
        } 
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            x = 1;
        }

        var movement = new Vector2(x, y);
        var speed = 5;
        _rigidBody.velocity = movement * speed;

        if (_rigidBody.velocity.x > 0)
        {
            transform.rotation = Quaternion.Euler(0,0,270);
        }
        else if (_rigidBody.velocity.x < 0)
        {
            transform.rotation = Quaternion.Euler(0,0,90);
        }
        if (_rigidBody.velocity.y > 0)
        {
            transform.rotation = Quaternion.Euler(0,0,0);
        } 
        else if (_rigidBody.velocity.y < 0)
        {
            transform.rotation = Quaternion.Euler(0,0,180);
        }
    }
}
