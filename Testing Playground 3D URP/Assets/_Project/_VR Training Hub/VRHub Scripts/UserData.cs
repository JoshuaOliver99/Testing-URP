using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Script attatched to each user containing user specific information.
/// </summary>
public class UserData : MonoBehaviour
{
    [Header("User descriptors")]
    [SerializeField, Tooltip("Individual User ID")]     int id;
    [SerializeField, Tooltip("Individual User Name")]   string username;
    [SerializeField, Tooltip("Individual User Color")]  Color color;

    [Header("UI")]
    [SerializeField, Tooltip("Using righthanded mode")]   bool useRightHanded;
    bool mannequinTutorial;     // Potential Tutorial          

    [Header("Social")]
    [SerializeField, Tooltip("User is self muted")]                     bool mutedSelf;
    [SerializeField, Tooltip("Array of all user muted individuals")]    bool[] mutedPlayers = new bool[13]; // 13 users
    [SerializeField, Tooltip("User has hand raised")]                   bool handRaised;
    [SerializeField, Tooltip("User is delared ready")]                  bool ready;

    [Header("Mannequin")]
    [SerializeField, Tooltip("")]   LoadoutMannequin unsavedMannequin;
    [SerializeField, Tooltip("")]   List<LoadoutMannequin> savedMannequins;

    [Header("Grab Bag")]
    [SerializeField, Tooltip("")]   LoadoutGrabBag unsavedGrabBag;
    [SerializeField, Tooltip("")]   List<LoadoutGrabBag> savedGrabBags;

}
