using System;
using UnityEditor.Experimental.GraphView;
using UnityEditor.VersionControl;
using UnityEngine;

public interface ICommand
{
    void Execute();
}
[System.Serializable]
public class MoveCommand : ICommand
{
    [SerializeField] private Character character;

    [SerializeField] private Direction direction;

    public MoveCommand(Character character, Direction direction)
    {
        this.character = character;
        this.direction = direction;
    }
    public void Execute()
    {
        character.Move(direction);
    }
}

[System.Serializable]
public class TalkCommand : ICommand
{
    [SerializeField] private Character character;

    [SerializeField] private string message;

    public TalkCommand(Character character, String message)
    {
        this.character = character;
        this.message = message;
    }
    public void Execute()
    {
        character.Talk(message);
    }
}
