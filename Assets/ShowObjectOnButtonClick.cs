using UnityEngine;
using UnityEngine.UI;

public class ShowObjectOnButtonClick : MonoBehaviour
{
    public GameObject objectToShow; // 要显示的对象
    public Button showButton; // 触发显示的按钮

    void Start()
    {
        // 确保对象初始时隐藏
        if (objectToShow != null)
        {
            objectToShow.SetActive(false);
        }

        // 添加按钮点击事件监听器
        if (showButton != null)
        {
            showButton.onClick.AddListener(ShowObject);
        }
    }

    void ShowObject()
    {
        // 显示对象
        if (objectToShow != null)
        {
            objectToShow.SetActive(true);
        }
    }
}
