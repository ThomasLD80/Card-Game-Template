using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gm;
    public List<Card> deck = new List<Card>();
    //public List<Card> player_deck = new List<Card>();
    //public List<Card> ai_deck = new List<Card>();
    public List<Card> player_hand = new List<Card>();
    public List<Card> ai_hand = new List<Card>();
    public List<Card> discard_pile = new List<Card>();

    public float offset;
    public Transform canvas;
    public List<Color> colorList = new List<Color>();

    public GameObject cardToSpawn;
    public Card_data cardValues;
    
    
    private void Awake()
    {
        if (gm != null && gm != this)
        {
            Destroy(gameObject);
        }
        else
        {
            gm = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        colorList[0] = new Color(0, 0, 1, 1);
        colorList[1] = new Color(0, 1, 0, 1);
        colorList[2] = new Color(1, 0, 0, 1);
        colorList[3] = new Color(1, 0.92f, 0.016f, 1);

        for (int number = 0; number < 10; number++)
        {
            for (int colorIndex = 0; colorIndex < 4; colorIndex++)
            {
                deck.Add(new Card(null, null, null, colorList[colorIndex], number));
            }
        }
        
        Deal(7);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateCard()
    {
        // Instantiate a card with defined values
        
        //GameObject card = Instantiate(cardToSpawn,)
    }

    void CreateDeck()
    {
        
    }
    
    void Deal(int handSize)
    {
        for (int i = 0; i < handSize; i++)
        {
            int cardIndex = Random.Range(0, deck.Count);
            Card card = Instantiate(deck[cardIndex], new Vector3(0 + offset, 200, 0),
                Quaternion.identity);
            player_hand.Add(card);
            card.transform.SetParent(canvas);
            deck.RemoveAt(cardIndex);
            offset += 300;
        }
    }

    void Shuffle()
    {

    }

    void AI_Turn()
    {

    }



    
}
