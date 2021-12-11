using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateMoonies : MonoBehaviour {
    public static int totalMoonies = 0;
    Text mooniesText;

    void Start () {
        mooniesText = GetComponent<Text> ();
    }

    void Update () {
        mooniesText.text = "Total Moonies: " + totalMoonies;
    }

}
