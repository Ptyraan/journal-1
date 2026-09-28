using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float maxFloatDistance;
    public Vector3 destination;
    public float moveSpeed;
    public float arrivalDistance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        destination = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Magnitude(destination - transform.position) < arrivalDistance) 
        {
            destination = new Vector3(transform.position.x + Random.Range(-1, 1) * maxFloatDistance, transform.position.y + Random.Range(-1, 1) * maxFloatDistance, 0);
            if (Vector3.Magnitude(destination - transform.position) > maxFloatDistance)
            {
                destination = transform.position + (destination - transform.position)/Vector3.Magnitude(destination - transform.position) * maxFloatDistance;
            }
        }
        else
        {
            if (Vector3.Magnitude(destination - transform.position) < moveSpeed * Time.deltaTime)
            { 
                transform.position = destination;
            }
            else
            {
                Vector3 pos = transform.position + (destination - transform.position)/ Vector3.Magnitude(destination - transform.position) * moveSpeed * Time.deltaTime;
                transform.position = pos;
            }
        }
    }
}
