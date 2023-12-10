using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    public bool IsActive = true;
    [SerializeField] private float speed;
    [SerializeField] private Text txtMessage;
    [SerializeField] protected Game game;
    public void Move(Direction direction)
    {
        var moveStep = new Vector2(0, 0);
        switch (direction)
        {
            case Direction.Left:
                moveStep = new Vector2(-speed, 0);
                break;
            case Direction.Right:
                moveStep = new Vector2(speed, 0);
                break;
            case Direction.Up:
                moveStep = new Vector2(0, speed);
                break;
            case Direction.Down:
                moveStep = new Vector2(0, -speed);
                break;
        }
        transform.Translate(moveStep);
    }
    public void Talk(string message)
    {
        txtMessage.text = message;
    }
}
public enum Direction
{
    Left = 0,
    Right = 1,
    Up = 2,
    Down = 3
}