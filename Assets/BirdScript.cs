using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D BirdRigidBody;
    public float JumpStrength;
    void Start()
    {
        Vector2 startPosition = transform.position;
        startPosition.y = 0;
        transform.position = startPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            BirdRigidBody.velocity = Vector2.up * JumpStrength;
        }
    }
}
