using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public Transform enemyTransform;
    public GameObject bombPrefab;
    public List<Transform> asteroidTransforms;
    public float bombTrailSpacing;
    public int numberOfTrailBombs;
    public float warpRatio;

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.bKey.wasPressedThisFrame)
        {
            SpawnBombAtOffset(new Vector3(0, 1));
        }
        if (Keyboard.current.tKey.wasPressedThisFrame)
        {
            SpawnBombTrail(bombTrailSpacing, numberOfTrailBombs);
        }
        if (Keyboard.current.rKey.wasPressedThisFrame)
        {
            SpawnBombOnRandomCorner(bombTrailSpacing);
        }
        if (Keyboard.current.wKey.wasPressedThisFrame)
        {
            WarpPlayer(enemyTransform, warpRatio);
        }
    }

    public void SpawnBombAtOffset(Vector3 inOffset)
    {
        Instantiate(bombPrefab, transform.position + inOffset, transform.rotation);
    }

    public void SpawnBombTrail(float inBombSpacing, int inNumberOfBombs)
    { 
        for (int i = 0; i < inNumberOfBombs; i++)
        {
            SpawnBombAtOffset(new Vector3(0, -(i + 1) * inBombSpacing));
        }
    }

    public void SpawnBombOnRandomCorner(float inDistance)
    {
        Vector3 direction;
        float r = Random.Range(0, 4);
        if (r < 1)
        {
            direction = new Vector3(1, 1);
        }
        else if (r < 2)
        {
            direction = new Vector3(-1, 1);
        }
        else if (r < 3)
        {
            direction = new Vector3(1, -1);
        }
        else
        {
            direction = new Vector3(-1, -1);
        }
        SpawnBombAtOffset(direction / Mathf.Sqrt(2) * inDistance);
    }

    public void WarpPlayer(Transform target, float ratio)
    {
        if (ratio <= 1 && ratio >= 0)
        { 
            Vector3 pos = transform.position;
            Vector3 delta = target.position - pos;
            pos += delta * ratio;
            transform.position = pos;

        }
    }
}
