using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Singleton to represent the game of mafia
public class MafiaGame : MonoBehaviour {
    public static MafiaGame instance;

    public GameMode[] availableGameModes;

    private void Awake()
    {
        instance = this;
    }
}
