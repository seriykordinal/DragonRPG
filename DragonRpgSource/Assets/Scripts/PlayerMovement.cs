using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float Speed;
    private Rigidbody _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        Move();
    }
    private void Move()
    {


        if (Input.GetKey(KeyCode.W))
        {
            _rb.AddForce(Vector3.forward *  Speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            _rb.AddForce(Vector3.back * Speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            _rb.AddForce(Vector3.left * Speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            _rb.AddForce(Vector3.right * Speed * Time.deltaTime);
        }


    }
}
