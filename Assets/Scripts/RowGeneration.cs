using UnityEngine;

public class RowGeneration : MonoBehaviour
{
    public string countText;
    public int count;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewNumber()
    {
        if (int.TryParse(countText, out count))
        {

        }
        else
        {
            count = 0;
        }
    }

    public void Squares()
    {
        Vector2 location = new Vector2(0, 0);
        for (int i = 0; i < count; i++) 
        { 
            drawSquare(location, 1);
            location.x += 2;
        }
    }

    void drawSquare(Vector2 pos, float size)
    {
        Debug.DrawLine(new Vector2(pos.x - size / 2, pos.y - size / 2), new Vector2(pos.x + size / 2, pos.y - size / 2), new Color(1, 1, 1, 1));
        Debug.DrawLine(new Vector2(pos.x - size / 2, pos.y + size / 2), new Vector2(pos.x + size / 2, pos.y + size / 2), new Color(1, 1, 1, 1));
        Debug.DrawLine(new Vector2(pos.x - size / 2, pos.y - size / 2), new Vector2(pos.x - size / 2, pos.y + size / 2), new Color(1, 1, 1, 1));
        Debug.DrawLine(new Vector2(pos.x + size / 2, pos.y - size / 2), new Vector2(pos.x + size / 2, pos.y + size / 2), new Color(1, 1, 1, 1));
    }
}
