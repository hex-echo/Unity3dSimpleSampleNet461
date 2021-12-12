using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncomeCalculator : MonoBehaviour {
    public static int totalMiners = 0;
    public static int minerRate = 1;

    private static int passiveMoonieIncome = 0;
    private static int activeMoonieIncome = 1;

    private static int passiveWoodIncome = 0;
    private static int activeWoodIncome = 1;


    // UpdateIncome updates the total income auto-mining values based on passive income and current active task
    public static void UpdateIncome() {
        int totalMoonieIncome = passiveMoonieIncome;
        int totalWoodIncome = passiveWoodIncome;

        switch (CurrentTask.getCurrentTask()) {
            case CurrentTask.miningMoonieString :
                totalMoonieIncome += activeMoonieIncome;
                break;
            case CurrentTask.cuttingWoodString :
                totalWoodIncome += activeWoodIncome;
                break;
        }

        AutoMiner.moonieIncome = totalMoonieIncome;
        AutoMiner.woodIncome = totalWoodIncome;
        
    }

    public void AddMiner () {
        totalMiners += 1;
        UpdatePassiveMiningIncome();
    }

    public void UpgradePickaxes () {
        minerRate += 1;
        activeMoonieIncome += 1;
        UpdatePassiveMiningIncome();
    }

    private void UpdatePassiveMiningIncome () {
        passiveMoonieIncome = minerRate * totalMiners;
        UpdateMiningIncome();
    }

    private void UpdateMiningIncome() {
        int totalMoonieIncome = passiveMoonieIncome;
        if(CurrentTask.getCurrentTask() == CurrentTask.miningMoonieString) {
            totalMoonieIncome += activeMoonieIncome;            
        }
        AutoMiner.moonieIncome = totalMoonieIncome;
    }

    private void UpdateWoodIncome() {
        int totalWoodIncome = passiveWoodIncome;
        if(CurrentTask.getCurrentTask() == CurrentTask.cuttingWoodString) {
            totalWoodIncome += activeWoodIncome;            
        }
        AutoMiner.woodIncome = totalWoodIncome;
    }
}
