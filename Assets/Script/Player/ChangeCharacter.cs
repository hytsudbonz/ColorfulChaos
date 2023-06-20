using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class ChangeCharacter : MonoBehaviour
{
    [SerializeField] List<Sprite> spritechars;
    List<Color> colorchars;

    SpriteRenderer spritechar;
    private void Start()
    {
        spritechar = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(ChangeChar());
            StartCoroutine(ColorChar());
        }
    }
    public IEnumerator ChangeChar()
    {
        if (spritechar) 
        {
            spritechar.sprite = spritechars[Random.Range(0, spritechars.Count)];
        }
        yield return null;
    }
    public IEnumerator ColorChar()
    {
        Color red = Color.red;
        Color green = Color.green;
        Color blue = Color.blue;
        Color yellow = Color.yellow;
        Color white = Color.white;
        colorchars.Add(red);
        colorchars.Add(green);
        colorchars.Add(blue);
        colorchars.Add(yellow);
        colorchars.Add(white);
        if (spritechar)
        {
            int randomInt = Random.Range(0, colorchars.Count);
            spritechar.material.color = colorchars[randomInt];
        }
        yield return null;
    }
}