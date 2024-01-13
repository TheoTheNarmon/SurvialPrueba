using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healing : MonoBehaviour
{
    public float liveHeal;
    public float stressHeal;
    public LifeBar HealthBar;
    public LifeBar StressBar;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            HealthBar.sumBar(liveHeal);
            StressBar.sumBar(-stressHeal);
            Destroy(gameObject);
        }
    }
}
