using UnityEngine;

public class Snake : MonoBehaviour
{
    [SerializeField] private float _movementSpeed = 10f;

    private Vector3 _direction = Vector2.right;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
            _direction = Vector2.left;
        else if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
            _direction = Vector2.right;
        else if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            _direction = Vector2.up;
        else if(Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
            _direction = Vector2.down;
    }

    private void FixedUpdate()
    {
        transform.position = new Vector3(
            Mathf.Round(transform.position.x) + _direction.x,
            Mathf.Round(transform.position.y) + _direction.y,
            0f);
    }
}
