using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    private float Speed = 50f;
    private Rigidbody2D rb;

    // Update is called once per frame
    private void Start()
    {
        var rb = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float InputY = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(0, Speed * InputY);

        if (Input.GetButtonDown("Space"))
        {
            rb.AddRelativeForce(new Vector2(5, 0));
        }
    }
}