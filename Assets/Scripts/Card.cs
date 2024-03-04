using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    public Card_data data;

    public string card_name;
    public string description;
    public Sprite sprite;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;
    public Image spriteImage;

    public Color color;
    public int number;

    public TextMeshProUGUI colorText;
    public TextMeshProUGUI numberText;
    
    // Start is called before the first frame update
    void Start()
    {
        card_name = data.card_name;
        description = data.description;
        sprite = data.sprite;
        nameText.text = card_name;
        descriptionText.text = description;
        spriteImage.sprite = sprite;

        
        color = data.color;
        number = data.number;

        colorText.text = color.ToString();
        numberText.text = number.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
