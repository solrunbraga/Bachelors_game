using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CharacterSelectButton : MonoBehaviour, IPointerEnterHandler,
    IPointerExitHandler,
    IPointerClickHandler
{
    [Header("Character")]
    public Sprite showcaseSprite;

    [Header("P1 Showcase")]
    public Image p1Showcase;

    [Header("P1 Visuals")]
    public GameObject p1Hover;
    public GameObject p1Selected;

    // Currently selected character
    private static CharacterSelectButton currentP1Selection;

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Show hover graphic
        if (p1Hover != null)
        {
            p1Hover.SetActive(true);
        }

        // Only change showcase if no character has been selected yet
        if (currentP1Selection == null)
        {
            ShowCharacter();
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (p1Hover != null)
        {
            p1Hover.SetActive(false);
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        SelectForP1();
    }

    public void SelectForP1()
    {
        // Turn off previous selection
        if (currentP1Selection != null &&
            currentP1Selection != this)
        {
            if (currentP1Selection.p1Selected != null)
            {
                currentP1Selection.p1Selected.SetActive(false);
            }
        }

        // Set new selection
        currentP1Selection = this;

        // Turn on selected graphic
        if (p1Selected != null)
        {
            p1Selected.SetActive(true);
        }

        // Change showcase to newly selected character
        ShowCharacter();
    }

    private void ShowCharacter()
    {
        if (p1Showcase != null && showcaseSprite != null)
        {
            p1Showcase.sprite = showcaseSprite;
            p1Showcase.enabled = true;
        }
    }
}
