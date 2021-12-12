using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateCurrentTask : MonoBehaviour {
    Text taskText;

    void Start () {
        taskText = GetComponent<Text> ();
    }

    void Update () {
        taskText.text = "Current task: " + CurrentTask.getCurrentTask();
    }
}
