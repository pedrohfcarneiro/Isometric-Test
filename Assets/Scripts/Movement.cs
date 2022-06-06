using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Vector2 input = new Vector2();
    public float speed = 2f;
    
    void Start()
    {

    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        input = new Vector2(x, y);

        Vector2 movement = Vector2.ClampMagnitude(input, 2f);
        Debug.Log(movement);

        transform.position += new Vector3(movement.x, movement.y, 0) * speed * Time.deltaTime;
    }
}
