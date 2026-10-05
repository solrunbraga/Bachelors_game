using UnityEngine;

[CreateAssetMenu(fileName = "New Fighter", menuName = "Fighters/Fighter Data")]
public class FighterData : ScriptableObject
{
    [Header("Basic Information")]
    public string fighterName;

    [TextArea(4, 10)]
    public string lore;

    [Header("Images")]
    public Sprite portrait;
    public Sprite showcaseImage;

    [Header("Difficulty")]
    [Range(1, 5)]
    public int difficulty = 1;

    [Header("Stats")]
    [Range(1, 5)]
    public int power = 1;

    [Range(1, 5)]
    public int mobility = 1;

    [Range(1, 5)]
    public int health = 1;

    [Range(1, 5)]
    public int range = 1;
}