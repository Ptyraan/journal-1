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
}
