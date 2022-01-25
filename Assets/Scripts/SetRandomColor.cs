using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRandomColor : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;

    private void Awake() => _spriteRenderer = GetComponent<SpriteRenderer>();


    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            _spriteRenderer.color = ChangeColor();
    }
    private Color ChangeColor()
    {
        return new Color(UnityEngine.Random.Range(0f, 1f),
            UnityEngine.Random.Range(0f, 1f),
            UnityEngine.Random.Range(0f, 1f));
    }
}
