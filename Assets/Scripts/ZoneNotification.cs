using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneNotification : MonoBehaviour
{
  public string zoneMessage = "Default Zone Message";

    private void OnTriggerEnter(Collider other)
    {
        // Check if the entering object is the player
        if (other.CompareTag("Player"))
        {
            // Player has entered the zone, trigger notification
            ShowNotification(zoneMessage);
        }
    }

    private void ShowNotification(string message)
    {
        GameObject notificationTextObject = GameObject.Find("notificationText");

        if (notificationTextObject != null)
        {
            UnityEngine.UI.Text notificationText = notificationTextObject.GetComponent<UnityEngine.UI.Text>();

            if (notificationText != null)
            {
                notificationText.text = message;
            }
        }
    }
}