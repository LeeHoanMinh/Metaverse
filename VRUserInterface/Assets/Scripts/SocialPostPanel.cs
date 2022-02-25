using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocialPostPanel : MonoBehaviour
{
    public GameObject mainCharacter;

    private void Update() 
    {
        transform.LookAt(2 * transform.position - mainCharacter.transform.position);
    }
}
