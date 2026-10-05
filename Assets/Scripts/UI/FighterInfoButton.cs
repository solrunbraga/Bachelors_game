using UnityEngine;

public class FighterInfoButton : MonoBehaviour
{
    public FighterData fighterData;
    public FighterInfoDisplay fighterInfoDisplay;

    [Header("Selection")]
    public GameObject selectedBorder;

    private static FighterInfoButton currentlySelected;

    public void SelectFighter()
    {
        // Turn off previous fighter's border
        if (currentlySelected != null &&
            currentlySelected != this)
        {
            if (currentlySelected.selectedBorder != null)
            {
                currentlySelected.selectedBorder.SetActive(false);
            }
        }

        // This fighter is now selected
        currentlySelected = this;

        // Show this fighter's border
        if (selectedBorder != null)
        {
            selectedBorder.SetActive(true);
        }

        // Display fighter information
        fighterInfoDisplay.DisplayFighter(fighterData);
    }
}
