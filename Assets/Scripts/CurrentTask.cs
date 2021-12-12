using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentTask : MonoBehaviour {
    public const string miningMoonieString = "Mining", 
        cuttingWoodString = "Chopping",
        doNothing = "None";

    private static string currentTask = doNothing;
  
    public void startMoonieMining () {
        currentTask = miningMoonieString;
        IncomeCalculator.UpdateIncome();
    }

    public void startCuttingWood () {
        currentTask = cuttingWoodString;
        IncomeCalculator.UpdateIncome();
    }

    public void takeARest () {
        currentTask = doNothing;
        IncomeCalculator.UpdateIncome();
    }

    public static string getCurrentTask () {
        return currentTask;
    }

}
