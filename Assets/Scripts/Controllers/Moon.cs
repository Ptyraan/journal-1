using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moon : MonoBehaviour
{
    public Transform planetTransform;
    public float r;
    public float s;
    public Transform tgt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OrbitalMotion(r, s, tgt);
    }

    public void OrbitalMotion(float radius, float speed, Transform target)
    {
        float angle = Mathf.Atan2(transform.position.y - target.position.y, transform.position.x - target.position.x);
        angle += speed * Time.deltaTime;
        Vector3 pos = new Vector3(target.position.x + radius * Mathf.Cos(angle), target.position.y + radius * Mathf.Sin(angle), 0);
        transform.position = pos;
    }
}
