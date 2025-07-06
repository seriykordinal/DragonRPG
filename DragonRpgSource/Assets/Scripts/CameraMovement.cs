using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    private Vector3 _offset = new Vector3(-1.5f, 1.5f, -3f);

    private void Update()
    {
        Move();
    }
    //сделать на колесико мышки отдаление
    void Move()
    {
        transform.position = Player.transform.position + _offset;

        if (Input.GetKeyDown(KeyCode.CapsLock))
        {
            _offset.x = -_offset.x;
        }
    }
}
