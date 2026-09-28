using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    public Vector3 velocity;
    public float power;
    public Transform tgt;
    public float maxSpeed;

    private void Update()
    {
        Vector3 acceleration = tgt.position - transform.position;
        acceleration.Normalize();
        velocity += acceleration * Time.deltaTime * power;
        if (Vector3.Magnitude(velocity) > maxSpeed)
        {
            velocity = velocity / Vector3.Magnitude(velocity) * maxSpeed;
        }
        Vector3 destination = transform.position + velocity * Time.deltaTime;
        transform.position = destination;
    }

}
