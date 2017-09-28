using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModeSelectScreenController : MonoBehaviour {
    public Dropdown modeSelect;

    private void Start()
    {
        ReloadAvailableModes();
    }

    public void ReloadAvailableModes()
    {
        modeSelect.ClearOptions();
        foreach (GameMode mode in MafiaGame.instance.availableGameModes)
        {
            modeSelect.options.Add(new Dropdown.OptionData() { text = mode.name });
        }
    }
}
