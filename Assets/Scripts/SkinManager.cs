using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinManager : MonoBehaviour
{
    static private SkinManager instance;

    public List<Sprite> playerSkins = new List<Sprite>();
    int selectedCat = 0;

    private SpriteRenderer spriteRenderer;
    private SelectManager selectManager;
    private GameObject player;

    // follows singleton pattern
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
            selectManager = GameObject.Find("SelectManager").GetComponent<SelectManager>();

        }
        else
        {
            Destroy(this);
            return;
        }
    }

    public void GetSprite(int selectedKitty)
    {
        selectedCat = selectedKitty;
    }

    public void SetSprite()
    {
        player = GameObject.Find("Player");

        spriteRenderer = player.GetComponent<SpriteRenderer>();
        if (spriteRenderer.sprite == null)
        {
            spriteRenderer.sprite = playerSkins[0];
        }

        spriteRenderer.sprite = playerSkins[selectedCat];
    }
}
