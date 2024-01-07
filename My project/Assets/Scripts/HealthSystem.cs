using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S : MonoBehaviour
{
    public LifeBar HealthBar;
    public LifeBar StressBar;

    private void Start()
    {
        HealthBar.BarInitialize(100f);
        StressBar.BarInitialize(20f);
        HealthBar.ChangeBarCurrent(36f);
        StressBar.ChangeBarCurrent(5f);

    }
}
