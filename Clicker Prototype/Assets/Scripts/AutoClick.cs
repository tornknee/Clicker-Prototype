using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]
public class AutoClick : MonoBehaviour
{
    public Toggle toggle;
    private int cost = 50;
    private Text toggleText;

    public int CostAuto
    {
        get { return cost; }
        set { cost = value; }
    }

    [SerializeField]
    private Points points;
    public Timer timer;

    //When toggle's value is changed run AutoOn function
    void Start()
    {
        toggle = gameObject.GetComponent<Toggle>();
        toggleText = gameObject.GetComponentInChildren<Text>();
        toggle.onValueChanged.AddListener(_auto => points.AutoOn());
    }

// If score is >= cost then toggle becomes interactable
void Update()
    {
        if (points.Score < cost)
        {
            toggle.interactable = false;
        }
        else
        {
            toggle.interactable = true;
        }
        toggleText.text = "Auto Click for " + timer.timeLeft + " seconds" + " Cost:" + cost;
    }

}
