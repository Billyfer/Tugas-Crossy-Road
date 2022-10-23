// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class OnOffMusic : MonoBehaviour
// {
//     [SerializeField] Image UnMute;
//     [SerializeField] Image Mute;
//     private bool muted = false;

//     // Start is called before the first frame update
//     void Start()
//     {
//         if (!PlayerPrefs.HasKey("muted"))
//         {
//             PlayerPrefs.SetInt("muted", 0);
//             Load();
//         }
//         else
//         {
//             Load();
//         }
//         UpdateButton();
//         AudioListener.pause = muted;

//     }

//     public void OnButtonPress()
//     {
//         if (muted == false)
//         {
//             muted = true;
//             AudioListener.pause = true;
//         }
//         else
//         {
//             muted = false;
//             AudioListener.pause = false;
//         }

//         Save();
//         UpdateButton();
//     }

//     private void UpdateButton()
//     {
//         if (muted == false)
//         {
//             soundOnButton.enabled = true;
//             soundOffButton.enabled = false;
//         }
//         else
//         {
//             soundOnButton.enabled = false;
//             soundOffButton.enabled = true;
//         }
//     }

//     private void Load()
//     {
//         muted = PlayerPrefs.GetInt("Muted") == 1;
//     }

//     private void Save()
//     {
//         PlayerPrefs.SetInt("Muted", muted ? 1 : 0);
//     }
// }
