using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class FighterInfoDisplay : MonoBehaviour
{
    [Header("Main Information")]
    public Image showcaseImage;
    public TMP_Text fighterName;
    public TMP_Text loreText;

    [Header("Information Panel")]
    public GameObject informationContent;

    [Header("Difficulty Stars")]
    public Image[] difficultyStars;

    [Header("Stat Bars")]
    public Image[] powerBars;
    public Image[] mobilityBars;
    public Image[] healthBars;
    public Image[] rangeBars;

    [Header("Colors")]
    public Color filledColor = Color.yellow;
    public Color emptyColor = Color.white;

    public void DisplayFighter(FighterData fighter)
    {

        if (fighter == null)
            return;

        informationContent.SetActive(true);

        // Main information
        fighterName.text = fighter.fighterName;
        loreText.text = fighter.lore;
        showcaseImage.sprite = fighter.showcaseImage;

        // Difficulty
        SetBars(difficultyStars, fighter.difficulty);

        // Stats
        SetBars(powerBars, fighter.power);
        SetBars(mobilityBars, fighter.mobility);
        SetBars(healthBars, fighter.health);
        SetBars(rangeBars, fighter.range);
    }

    private void SetBars(Image[] bars, int amount)
    {
        for (int i = 0; i < bars.Length; i++)
        {
            bars[i].color = i < amount ? filledColor : emptyColor;
        }
    }
}
