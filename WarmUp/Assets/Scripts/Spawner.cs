using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private const string SPRITE_TIMER = "SpriteTimer";

    [SerializeField] private Sprite[] _sprites;
    public Sprite[] Sprites
    {
        get { return _sprites; }
    }

    [SerializeField] private float _cooldown;
    public float Cooldown
    {
        get { return _cooldown; }
    }



	// Use this for initialization
	void Start ()
    {
        _cooldown = 1;
        InvokeRepeating(SPRITE_TIMER, 1, Cooldown);
	}

    private void SpriteTimer()
    {
        int spriteIndex = GetComponent<NumberGenerator>().Next();

        MakeSprite(spriteIndex);
    }

    private void MakeSprite(int spriteIndex)
    {
        GameObject gameobjSprite = new GameObject();
        SpriteRenderer renderer = gameobjSprite.AddComponent<SpriteRenderer>();
        renderer.sprite = Sprites[spriteIndex];

        gameobjSprite.AddComponent<Rigidbody2D>();
        
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
