using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class MainButton : MonoBehaviour
{
    private Button button;

    [SerializeField]
    private Points points;

    void Start()
    {
        button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(OnClickButton);
    }

    /// <summary>
    /// When button is clicked run AddPoints function
    /// </summary>
    private void OnClickButton()
    {
        points.AddPoints();
    }
}
