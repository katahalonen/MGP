using System.Collections;
using System.Collections.Generic;
using Unity.Notifications.Android;
using UnityEngine;

public class BasicNotification : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Channel Setup
        var channel = new AndroidNotificationChannel()
        {
            Id = "channel_id",
            Name = "Default Channel",
            Importance = Importance.Default,
            Description = "Generic notifications",
        };

        AndroidNotificationCenter.RegisterNotificationChannel(channel);

        // Notification Setup
        var notification = new AndroidNotification();
        notification.Title = "The game misses you!";
        notification.Text = "Come back please!";
        notification.FireTime = System.DateTime.Now.AddSeconds(10);

        AndroidNotificationCenter.SendNotification(notification, "channel_id");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
