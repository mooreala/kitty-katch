using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectManager : MonoBehaviour
{
    public Image currKitty;
    public List<Sprite> kitties = new List<Sprite>();
    private int selectedKitty = 0;

    SkinManager skinManager;

    private void Awake()
    {
        skinManager = GameObject.Find("SkinManager").GetComponent<SkinManager>();
    }

    public void Next()
    {
        // shows next char
        selectedKitty += 1;

        // seamless loop
        if (selectedKitty == kitties.Count)
        {
            selectedKitty = 0;
        }

        // update image
        currKitty.sprite = kitties[selectedKitty];
    }

    public void Back()
    {
        // shows prev char
        selectedKitty -= 1;

        // seamless loop
        if (selectedKitty < 0)
        {
            selectedKitty = kitties.Count - 1;
        }

        // update image
        currKitty.sprite = kitties[selectedKitty];
    }

    public void StartGame()
    {
        skinManager.GetSprite(selectedKitty);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
