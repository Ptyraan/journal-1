using UnityEngine;
using System.Collections.Generic;

public class Bomb : MonoBehaviour
{
    public Vector3 velocity;
    public Player player;
    public List<Transform> asteroids;
    public float gravityThreshold;
    public float gravity;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Fall();
        Vector3 pos = transform.position;
        pos += velocity * Time.deltaTime;
        transform.position = pos;
    }

    public void SetVelocity(Vector3 v)
    {
        velocity = v;
    }

    public void recordList(List<Transform> asteroidsTransforms)
    {
        for (int i = 0; i < asteroidsTransforms.Count; i++)
        {
            asteroids[i] = asteroidsTransforms[i];
        }
    }

    public void Fall()
    {
        for (int i = 0; i < asteroids.Count; i++)
        {
            Vector3 delta = asteroids[i].position - transform.position;
            if (Vector3.Magnitude(delta) < gravityThreshold)
            {
                velocity += delta * (Vector3.Magnitude(delta) / gravityThreshold) * gravity;
            }
        }
    }
}
