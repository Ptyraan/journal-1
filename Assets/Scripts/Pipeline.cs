using UnityEngine;
using UnityEngine.InputSystem;

public class Pipeline : MonoBehaviour
{
    public float CD = 1;
    public int count = 0;
    public Vector2[] points;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        points = new Vector2[count];
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.isPressed)
        { 
            CD -= Time.deltaTime;
            if (CD < 0) 
            {
                CD = 1;
                Vector2[] newPoints = new Vector2[count + 1];
                for (int i = 0; i < count; i++)
                {
                    newPoints[i] = points[i];
                }
                count += 1;
                newPoints[count] = new Vector2(Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue()).x, Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue()).y);
                points = newPoints;
            }
        }
        else
        {
            CD = 1;
            count = 0;
            points = new Vector2[count];
        }

        for (int i = 0; i < count; i++)
        {
            if (i != 0)
            {
                Debug.DrawLine(points[i], points[i - 1], Color.white);
            }
        }
    }
}
