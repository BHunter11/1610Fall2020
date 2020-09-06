using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterName : MonoBehaviour
{
    public string nameOfCharacter;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello! Your name is" + nameOfCharacter + "Press Start to Begin!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
