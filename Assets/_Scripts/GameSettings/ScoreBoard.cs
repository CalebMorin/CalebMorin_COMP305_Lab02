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

[CreateAssetMenu(fileName = "ScoreBoard", menuName = "Game/ScoreBoard")]
[System.Serializable]
public class ScoreBoard : ScriptableObject
{
    public int highScore;
    public int lives;
    public int score;
}
