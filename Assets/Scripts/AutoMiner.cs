using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMiner : MonoBehaviour {
    public static int moonieIncome = 0;
    public static int woodIncome = 0;

    private int nextSecond = 1;

    // Update is called once per frame
    void Update() {
        if(Time.time >= nextSecond) {
            nextSecond = Mathf.FloorToInt(Time.time)+1;

            OnNextSecond();
        }
    }

    void OnNextSecond() {
        UpdateMoonies.totalMoonies += moonieIncome;
        UpdateWood.totalWood += woodIncome;
        Debug.Log("Total Moonies: " + UpdateMoonies.totalMoonies);
        Debug.Log("Total Wood: " + UpdateWood.totalWood);
    }
}
