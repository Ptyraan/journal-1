using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    public Vector3 velocity;
    public float power;
    public Transform tgt;
    public float maxSpeed;
    public float r;
    public int n;

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
        EnemyRadar(r, n);
    }

    public void EnemyRadar(float radius, int circlePoints)
    {
        Vector2 previous = new Vector2(transform.position.x, transform.position.y + radius);
        for (float i = 1; i < circlePoints + 2; i++)
        {
            float angle = 2 * Mathf.PI / circlePoints * i;
            if (Vector3.Magnitude(tgt.position - transform.position) > radius)
            {
                Debug.DrawLine(previous, new Vector2(transform.position.x + radius * Mathf.Cos(angle), transform.position.y + radius * Mathf.Sin(angle)), new Color(0, 1, 0, 1));
            }
            else
            {
                Debug.DrawLine(previous, new Vector2(transform.position.x + radius * Mathf.Cos(angle), transform.position.y + radius * Mathf.Sin(angle)), new Color(1, 0, 0, 1));
            }
                previous = new Vector2(transform.position.x + radius * Mathf.Cos(angle), transform.position.y + radius * Mathf.Sin(angle));
        }
    }
}
