using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    private List<ICommand> tutorialSteps = new List<ICommand>();
    [SerializeField] private Game game;
    public bool isActive = false;

    public void AddStep(ICommand command)
    {
        tutorialSteps.Add(command);
    }
    public void StartTutorial()
    {
        isActive = true;

    }
    public void NextStep()
    {
        if (!isActive)
        {
            return;
        }
        tutorialSteps[0].Execute();
        tutorialSteps.RemoveAt(0);
        if (tutorialSteps.Count == 0)
        {
            isActive = false;
        }
    }
}
