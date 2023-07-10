using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class enemycounter : MonoBehaviour
{
    public TextMeshProUGUI text;

    private void Update()
    {
        text.text = $"{DoorOpening.Enemy}";
    }
}
