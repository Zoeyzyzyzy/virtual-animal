using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PUDUAnimationController : MonoBehaviour
{
    public Animator animator; 
    public Button stayButton; 
    public Button spinButton;
    // public Button idleButton;
    public Button eatButton;
    public Button runButton;
    public Button sitButton;
    public Button sleepButton;

    public Button playButton;

    private string currentTrigger;

    void Start()
    {
        if (playButton != null)
        {
            playButton.onClick.AddListener(() => PlayAnimation("PlayTrigger"));
        }
        if (stayButton != null)
        {
            stayButton.onClick.AddListener(() => PlayAnimation("StayTrigger"));
        }
        if (spinButton != null)
        {
            spinButton.onClick.AddListener(() => PlayAnimation("SpinTrigger"));
        }
        if (eatButton != null)
        {
            eatButton.onClick.AddListener(() => PlayAnimation("EatTrigger"));
        }
        if (runButton != null)
        {
            runButton.onClick.AddListener(() => PlayAnimation("RunTrigger"));
        }
        if (sitButton != null)
        {
            sitButton.onClick.AddListener(() => PlayAnimation("SitTrigger"));
        }
        if (sleepButton != null)
        {
            sleepButton.onClick.AddListener(() => PlayAnimation("SleepTrigger"));
        }
    }

    void PlayAnimation(string triggerName)
    {
        if (animator != null)
        {

            ResetAllTriggers();

            animator.SetTrigger("StayTrigger");

            animator.SetTrigger(triggerName);
        }
    }

    void ResetAllTriggers()
    {
        foreach (AnimatorControllerParameter parameter in animator.parameters)
        {
            if (parameter.type == AnimatorControllerParameterType.Trigger)
            {
                animator.ResetTrigger(parameter.name);
            }
        }
    }
}
