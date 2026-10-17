using UnityEngine;

public class Bomb : MonoBehaviour
{
    public Vector3 velocity;
    public Player player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos += velocity * Time.deltaTime;
        transform.position = pos;
    }

    public void SetVelocity(Vector3 v)
    {
        velocity = v;
    }
}
