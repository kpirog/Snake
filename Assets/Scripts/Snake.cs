using UnityEngine;
using System.Collections.Generic;

public class Snake : MonoBehaviour
{
    [SerializeField] private Transform _segmentPrefab;

    private List<Transform> _segments = new List<Transform>();

    private Vector3 _direction = Vector2.right;

    private void Start()
    {
        _segments.Add(transform);
    }

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
        for (int i = _segments.Count - 1; i > 0; i--)
        {
            _segments[i].position = _segments[i - 1].position;
        }
        
        transform.position = new Vector3(
            Mathf.Round(transform.position.x) + _direction.x,
            Mathf.Round(transform.position.y) + _direction.y,
            0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Food"))
            Grow();
    }

    private void Grow()
    {
        Transform newSegment = Instantiate(_segmentPrefab);

        newSegment.position = _segments[_segments.Count - 1].position;

        _segments.Add(newSegment);
    }
}
