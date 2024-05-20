// using UnityEngine;
// using UnityEngine.UI;

// public class AnimalAnimationController : MonoBehaviour
// {
//     public Animator animator; 
//     public Button playButton; 
//     public Button spinButton;

//     public Button idleButton;

//     void Start()
//     {
//         // 添加按钮点击事件监听器
//         if (playButton != null)
//         {
//             playButton.onClick.AddListener(() => PlayAnimation("AttackTrigger"));
//         }
//         if (spinButton != null)
//         {
//             spinButton.onClick.AddListener(() => PlayAnimation("SpinTrigger"));
//         }
//         if(idleButton != null){
//             idleButton.onClick.AddListener(() => PlayAnimation("IdleTrigger"));
//         }
//     }

//     void PlayAnimation(string triggerName)
//     {
//         if (animator != null && triggerName != "IdleTrigger")
//         {
//             // 重置所有触发器
//             ResetAllTriggers();
            
//             // // 触发默认状态（可选）
//             animator.SetTrigger("IdleTrigger");

//             // 触发按钮对应的动画
//             animator.SetTrigger(triggerName);
//         } else{
//             ResetAllTriggers();
//             animator.SetTrigger("IdleTrigger");
//         }
//     }

//     void ResetAllTriggers()
//     {
//         foreach (AnimatorControllerParameter parameter in animator.parameters)
//         {
//             if (parameter.type == AnimatorControllerParameterType.Trigger)
//             {
//                 animator.ResetTrigger(parameter.name);
//             }
//         }
//     }
// }
