using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///Project Information
/// 
/// Name: Caleb Morin
/// ID: 301012814  
/// Original Author: Tom Tsiliopolous
/// Last Edited: 11/9/2019
/// 
///Project Information
[System.Serializable]
[CreateAssetMenu(fileName = "SceneSettings", menuName = "Scene/Settings")]
public class SceneSettings : ScriptableObject
{
    [Header("Scene Config")]
    public Scene scene;
    public SoundClip activeSoundClip;

    [Header("Scoreboard Config")]
    public bool scoreLabelEnabled;
    public bool highScoreLabelEnabled;

    [Header("Scene Labels")]
    public bool livesLabelEnabled;
    public bool startLabelActive;
    public bool endLabelActive;

    [Header("Scene Buttons")]
    public bool startButtonActive;
    public bool restartButtonActive;
}
