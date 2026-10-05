using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CharacterSelectButton : MonoBehaviour, IPointerEnterHandler
{
    [Header("Character")]
    public Sprite showcaseSprite;

    [Header("P1 Showcase")]
    public Image p1Showcase;

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (p1Showcase != null && showcaseSprite != null)
        {
            p1Showcase.sprite = showcaseSprite;
            p1Showcase.enabled = true;
        }
    }
}
