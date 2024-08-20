using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f;
    public float maxX = 8f;

    void Update()
    {
        float input = Input.GetAxis("Horizontal");
        Vector2 newPosition = transform.position + Vector3.right * input * speed * Time.deltaTime;

        newPosition.x = Mathf.Clamp(newPosition.x, -maxX, maxX);

        transform.position = newPosition;
    }
}
