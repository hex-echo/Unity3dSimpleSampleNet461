using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetMoonie : MonoBehaviour {

    public void updateMoonies () {
        UpdateMoonies.totalMoonies += IncomeCalculator.minerRate;
    }

}