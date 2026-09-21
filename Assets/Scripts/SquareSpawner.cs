using UnityEngine;
using UnityEngine.InputSystem;

public class SquareSpawner : MonoBehaviour
{
    public float size;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(new Vector2(0, 0), new Vector2(1, 1), Color.white);
        Vector3 cursor = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        cursor.z = 0;
        //size -= Input.mouseScrollDelta.y / 3;
        if (size < 0.2f) size = 0.2f;
        if (size > 5) size = 5;
        Debug.DrawLine(new Vector2(cursor.x - size / 2, cursor.y - size / 2), new Vector2(cursor.x + size / 2, cursor.y - size / 2), new Color(1, 1, 1, 0.5f));
        Debug.DrawLine(new Vector2(cursor.x - size / 2, cursor.y + size / 2), new Vector2(cursor.x + size / 2, cursor.y + size / 2), new Color(1, 1, 1, 0.5f));
        Debug.DrawLine(new Vector2(cursor.x - size / 2, cursor.y - size / 2), new Vector2(cursor.x - size / 2, cursor.y + size / 2), new Color(1, 1, 1, 0.5f));
        Debug.DrawLine(new Vector2(cursor.x + size / 2, cursor.y - size / 2), new Vector2(cursor.x + size / 2, cursor.y + size / 2), new Color(1, 1, 1, 0.5f));
        if (Mouse.current.leftButton.isPressed)
        {
            Debug.DrawLine(new Vector2(cursor.x - size / 2, cursor.y - size / 2), new Vector2(cursor.x + size / 2, cursor.y - size / 2), Color.white);
            Debug.DrawLine(new Vector2(cursor.x - size / 2, cursor.y + size / 2), new Vector2(cursor.x + size / 2, cursor.y + size / 2), Color.white);
            Debug.DrawLine(new Vector2(cursor.x - size / 2, cursor.y - size / 2), new Vector2(cursor.x - size / 2, cursor.y + size / 2), Color.white);
            Debug.DrawLine(new Vector2(cursor.x + size / 2, cursor.y - size / 2), new Vector2(cursor.x + size / 2, cursor.y + size / 2), Color.white);
        }

    }
}
