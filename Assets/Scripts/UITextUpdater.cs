using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UITextUpdater : MonoBehaviour
{
    //When this button is clicked,
    //Update the game text objext
    //We need a reference to our text objecct
    [SerializeField] private TextMeshProUGUI messageLabel;
    [SerializeField] private string message;
    public void UpdateText()
    {
        messageLabel.text = "Whatever you have on the ... yep" + message;
    }
}

