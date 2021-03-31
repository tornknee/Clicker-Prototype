using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TMPro;

[RequireComponent(typeof(Button))]
public class UpgradeClick : MonoBehaviour
{
    private Button button;
    private int cost = 10;

    public int Cost
    { get { return cost; }
        set { cost = value; }
    }

    [SerializeField]
    private Points points;

    private TextMeshProUGUI buttonText;

    void Start()
    {
        button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(OnClickButton);
        buttonText = gameObject.GetComponentInChildren<TextMeshProUGUI>();
    }

    /// <summary>
    /// If players score is less than the cost of the upgrade, the button is not interactable.
    /// </summary>
    void Update()
    {
        if (points.Score < cost)
        {
            button.interactable = false;
        }
        else
        {
            button.interactable = true;
        }
        buttonText.text = "Exponential Clicks Cost:" + cost + " " +"Click Value:" + points.Increment;
    }


    /// <summary>
    /// When button is clicked run IncreaseIncrement function and IncreaseCost function
    /// </summary>
    public void OnClickButton()
    {
        points.IncreaseIncrement();
        IncreaseCost();
    }

    /// <summary>
    /// Multiplies the cost of the upgrade by a random number between 2 and 10.
    /// </summary>
    public void IncreaseCost()
    {
        int random = Random.Range(2, 10);
        cost *= random;
        Cost = cost;
    }
}
