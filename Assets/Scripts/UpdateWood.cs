using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateWood : MonoBehaviour {
    public static int totalWood = 0;
    Text woodText;

    void Start () {
        woodText = GetComponent<Text> ();
    }

    void Update () {
        woodText.text = "Total Wood: " + totalWood;
    }

}
