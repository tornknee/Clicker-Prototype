using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField]
    public AutoClick auto;
    public Points points;

    public float timeLeft = 5;
    public float newTime;

    // Update is called once per frame
    void Update()
    {
        // Checks if AutoClick toggle is on and if so starts timer
        if (auto.toggle.isOn == true)
        {
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
            }
            //When timer runs out toggle is switched off and the length the timer runs for is doubled as is the cost.
            else
            {
                auto.toggle.isOn = false;
                timeLeft = newTime;
                newTime += newTime;
                auto.CostAuto += auto.CostAuto;
            }
        }
    }
}
