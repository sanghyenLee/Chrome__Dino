using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float MoveSpeed = 8f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * MoveSpeed * Time.deltaTime);
    }
}