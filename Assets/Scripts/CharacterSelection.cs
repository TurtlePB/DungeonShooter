using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelection : MonoBehaviour
{
    [SerializeField] private GameObject[] characterPrefabs;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private Button[] characterButtons;

    private GameObject currentCharacter;
    private int selectedCharacterIndex = -1;

    private void Start()
    {
        //UnachievedCharacters();
    }

    public void SelectCharacter(int characterIndex)
    {
        if (characterIndex >= 0 && characterIndex < characterPrefabs.Length)
        {
            if (currentCharacter != null)
            {
                Destroy(currentCharacter);
            }
            
            currentCharacter = Instantiate(characterPrefabs[characterIndex], spawnPoint.position, Quaternion.identity);
        }
    }

    private void UnachievedCharacters()
    {
        foreach (var button in characterButtons)
        {
            button.interactable = false;
        }
        characterButtons[0].interactable = true;
    }
}
