using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class ChangeCharacter : MonoBehaviour
{
    [SerializeField] List<Sprite> spritechars = new List<Sprite>();
    [SerializeField] List<Color> colorchars = new List<Color>();

    SpriteRenderer spritechar;
    bool isCoroutineRun;
    private void Awake()
    {
        spritechar = GetComponent<SpriteRenderer>();
    }
    private void Start()
    {
        StartCoroutine(ChangeChar());
        StartCoroutine(ColorChar());
    }
    private void Update()
    {
    }
    public IEnumerator ChangeChar()
    {
        //int randomIndex = Random.Range(0, spritechars.Count);
        //Sprite randomChar = spritechars[randomIndex];
        //spritechar.sprite = randomChar;
        yield return null;
        spritechar.sprite = spritechars[Random.Range(0, spritechars.Count)];
    }
    public IEnumerator ColorChar()
    {
        //int randomIndex = Random.Range(0, colorchars.Count);
        //Color randomColor = colorchars[randomIndex];
        //spritechar.color = randomColor;
        yield return null;
        spritechar.color = colorchars[Random.Range(0, colorchars.Count)];
    }
}
