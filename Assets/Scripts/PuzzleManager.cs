using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    public SpriteRenderer[] puzzleSprites;
    public GameObject nextSection; // Reference to the next section of the game

    private Sprite[] targetSprites;

    private void Start()
    {
        targetSprites = new Sprite[puzzleSprites.Length];

        // Set the target sprites in the desired order
        for (int i = 0; i < targetSprites.Length; i++)
        {
            targetSprites[i] = puzzleSprites[i].sprite;
        }
    }

    private void Update()
    {
        // Check if the puzzle is solved
        if (IsPuzzleSolved())
        {
            MoveToNextSection();
        }
    }

    private bool IsPuzzleSolved()
    {
        for (int i = 0; i < puzzleSprites.Length; i++)
        {
            if (puzzleSprites[i].sprite != targetSprites[i])
            {
                return false;
            }
        }

        return true;
    }

    private void MoveToNextSection()
    {
        // Code to move to the next section of the game, such as loading a new scene or enabling/disabling GameObjects
        nextSection.SetActive(true);
    }
}