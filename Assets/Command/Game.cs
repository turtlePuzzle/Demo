using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private Character player;
    [SerializeField] private Character npc;
    [SerializeField] private Character truck;
    [SerializeField] private TutorialManager tutorialManager;
    [SerializeField] private ImageScreen imageEndTutorial;
    [SerializeField] private Sprite sprEndGame;

    private void Start()
    {
        InitListTutorial();
        StartTutorial();
    }
    void Update()
    {
        if (tutorialManager != null && tutorialManager.isActive && Input.GetKeyDown(KeyCode.Space))
        {
            tutorialManager.NextStep();
        }
        if (!player.IsActive)
            return;
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            player.Move(Direction.Left);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            player.Move(Direction.Right);
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            player.Move(Direction.Up);
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            player.Move(Direction.Down);
        }
    }
    public void InitListTutorial()
    {
        tutorialManager.AddStep(new MoveCommand(player, Direction.Right));
        tutorialManager.AddStep(new MoveCommand(player, Direction.Right));
        tutorialManager.AddStep(new MoveCommand(player, Direction.Right));
        tutorialManager.AddStep(new MoveCommand(player, Direction.Right));
        tutorialManager.AddStep(new MoveCommand(player, Direction.Right));
        tutorialManager.AddStep(new MoveCommand(player, Direction.Right));
        tutorialManager.AddStep(new MoveCommand(player, Direction.Right));
        tutorialManager.AddStep(new MoveCommand(player, Direction.Right));
        tutorialManager.AddStep(new MoveCommand(player, Direction.Right));
        tutorialManager.AddStep(new MoveCommand(player, Direction.Right));
        tutorialManager.AddStep(new MoveCommand(player, Direction.Right));
        tutorialManager.AddStep(new TalkCommand(npc, "Đứa nào đó"));
        tutorialManager.AddStep(new MoveCommand(npc, Direction.Up));
        tutorialManager.AddStep(new MoveCommand(npc, Direction.Up));
        tutorialManager.AddStep(new MoveCommand(npc, Direction.Up));
        tutorialManager.AddStep(new MoveCommand(npc, Direction.Up));
        tutorialManager.AddStep(new MoveCommand(npc, Direction.Left));
        tutorialManager.AddStep(new MoveCommand(npc, Direction.Left));
        tutorialManager.AddStep(new MoveCommand(npc, Direction.Left));
        tutorialManager.AddStep(new MoveCommand(npc, Direction.Up));
        tutorialManager.AddStep(new MoveCommand(npc, Direction.Up));
        tutorialManager.AddStep(new TalkCommand(npc, "Ăn trộm xoài hả"));
        tutorialManager.AddStep(new TalkCommand(player, "Xin trái làm gì căng"));
        tutorialManager.AddStep(new TalkCommand(npc, "50k 1 trái, không t báo trưởng làng"));
        tutorialManager.AddStep(new TalkCommand(player, "............"));
        tutorialManager.AddStep(new TalkCommand(player, "Bắt được rồi tính"));
        tutorialManager.AddStep(new TalkCommand(player, "Bấm A để di chuyển sang trái"));
        tutorialManager.AddStep(new MoveCommand(player, Direction.Left));
        tutorialManager.AddStep(new TalkCommand(player, "Bấm D để di chuyển sang phải"));
        tutorialManager.AddStep(new MoveCommand(player, Direction.Right));
        tutorialManager.AddStep(new TalkCommand(player, "Bấm S để di chuyển xuống dưới"));
        tutorialManager.AddStep(new MoveCommand(player, Direction.Down));
        tutorialManager.AddStep(new TalkCommand(player, "Bấm W để di chuyển lên trên"));
        tutorialManager.AddStep(new MoveCommand(player, Direction.Up));
        tutorialManager.AddStep(new TalkCommand(player, "Lêu lêu lêu lêu"));
        tutorialManager.AddStep(new MoveCommand(player, Direction.Up));
        tutorialManager.AddStep(new MoveCommand(player, Direction.Left));
        tutorialManager.AddStep(new MoveCommand(player, Direction.Left));
        tutorialManager.AddStep(new MoveCommand(player, Direction.Left));
        tutorialManager.AddStep(new MoveCommand(npc, Direction.Left));
        tutorialManager.AddStep(new MoveCommand(npc, Direction.Left));
        tutorialManager.AddStep(new MoveCommand(npc, Direction.Left));
        tutorialManager.AddStep(new TalkCommand(npc, "Đứng lạiiiiiiiiii"));
        tutorialManager.AddStep(new MoveCommand(player, Direction.Left));
        tutorialManager.AddStep(new MoveCommand(player, Direction.Left));
        tutorialManager.AddStep(new MoveCommand(player, Direction.Left));
        tutorialManager.AddStep(new MoveCommand(player, Direction.Left));
        tutorialManager.AddStep(new MoveCommand(player, Direction.Left));
        tutorialManager.AddStep(new MoveCommand(player, Direction.Left));
        tutorialManager.AddStep(new MoveCommand(player, Direction.Left));
        tutorialManager.AddStep(new MoveCommand(player, Direction.Left));
        tutorialManager.AddStep(new MoveCommand(player, Direction.Left));
        tutorialManager.AddStep(new MoveCommand(player, Direction.Left));
        tutorialManager.AddStep(new MoveCommand(player, Direction.Left));
        tutorialManager.AddStep(new MoveCommand(truck, Direction.Up));
        tutorialManager.AddStep(new MoveCommand(truck, Direction.Up));
        tutorialManager.AddStep(new MoveCommand(truck, Direction.Up));
        tutorialManager.AddStep(new MoveCommand(truck, Direction.Up));
        tutorialManager.AddStep(new MoveCommand(truck, Direction.Up));
        tutorialManager.AddStep(new MoveCommand(truck, Direction.Up));
        tutorialManager.AddStep(new MoveCommand(truck, Direction.Up));
        tutorialManager.AddStep(new MoveCommand(truck, Direction.Up));
        tutorialManager.AddStep(new MoveCommand(truck, Direction.Up));
        tutorialManager.AddStep(new MoveCommand(truck, Direction.Up));
        tutorialManager.AddStep(new MoveCommand(truck, Direction.Up));
        tutorialManager.AddStep(new MoveCommand(truck, Direction.Up));
        tutorialManager.AddStep(new MoveCommand(truck, Direction.Up));
        tutorialManager.AddStep(new MoveCommand(truck, Direction.Up));
        tutorialManager.AddStep(new MoveCommand(truck, Direction.Up));
        tutorialManager.AddStep(new MoveCommand(truck, Direction.Up));
        tutorialManager.AddStep(new TalkCommand(player, "AAAAAAAAAAAAAAAAAAAAAAAAAA"));
        tutorialManager.AddStep(new TalkCommand(player, "AAAAAAAAAAAAAAAAAAAAAAAAAA"));
        tutorialManager.AddStep(new TalkCommand(player, "hự hự hự hự"));
        tutorialManager.AddStep(new MoveCommand(truck, Direction.Up));
        tutorialManager.AddStep(new MoveCommand(truck, Direction.Up));
        tutorialManager.AddStep(new MoveCommand(truck, Direction.Up));
        tutorialManager.AddStep(new MoveCommand(truck, Direction.Up));
        tutorialManager.AddStep(new MoveCommand(truck, Direction.Up));
        tutorialManager.AddStep(new MoveCommand(truck, Direction.Up));
        tutorialManager.AddStep(new MoveCommand(truck, Direction.Up));
        tutorialManager.AddStep(new MoveCommand(truck, Direction.Up));
        tutorialManager.AddStep(new MoveCommand(truck, Direction.Up));
        tutorialManager.AddStep(new ShowImageCommand(imageEndTutorial, sprEndGame));



    }
    public void StartTutorial()
    {
        player.IsActive = false;
        npc.IsActive = false;
        tutorialManager.StartTutorial();
    }
    public void EndTutorial()
    {
        player.IsActive = true;
    }
}
