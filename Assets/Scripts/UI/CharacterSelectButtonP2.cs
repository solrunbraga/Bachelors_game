using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class CharacterSelectButtonP2 : MonoBehaviour,
    IPointerEnterHandler,
    IPointerExitHandler,
    IPointerClickHandler

{
    [Header("Character")]
    public Sprite showcaseSprite;

    [Header("P2 Showcase")]
    public Image p2Showcase;

    [Header("P2 Visuals")]
    public GameObject p2Hover;
    public GameObject p2Selected;

    // Currently selected character for P2
    private static CharacterSelectButtonP2 currentP2Selection;

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Show hover graphic
        if (p2Hover != null)
        {
            p2Hover.SetActive(true);
        }

        // Only change showcase if P2 hasn't selected someone yet
        if (currentP2Selection == null)
        {
            ShowCharacter();
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (p2Hover != null)
        {
            p2Hover.SetActive(false);
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        SelectForP2();
    }

    public void SelectForP2()
    {
        // Remove P2's previous selection
        if (currentP2Selection != null &&
            currentP2Selection != this)
        {
            if (currentP2Selection.p2Selected != null)
            {
                currentP2Selection.p2Selected.SetActive(false);
            }
        }

        // Set this as P2's new selection
        currentP2Selection = this;

        // Show selected graphic
        if (p2Selected != null)
        {
            p2Selected.SetActive(true);
        }

        // Update P2 showcase
        ShowCharacter();
    }

    private void ShowCharacter()
    {
        if (p2Showcase != null && showcaseSprite != null)
        {
            p2Showcase.sprite = showcaseSprite;
            p2Showcase.enabled = true;
        }
    }
}
