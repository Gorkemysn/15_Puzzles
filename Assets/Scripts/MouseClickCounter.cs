using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MouseClickCounter : MonoBehaviour
{
    public TextMeshProUGUI moveCountText;
    private int count;

    private void Start()
    {
        // Ensure you have a TextMeshProUGUI component attached to the same GameObject or assign it through the Inspector
        if (moveCountText == null)
            moveCountText = GetComponent<TextMeshProUGUI>();

        UpdateMoveCountText();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            count++;
            UpdateMoveCountText();
        }
    }

    private void UpdateMoveCountText()
    {
        moveCountText.text = count.ToString();
    }
}