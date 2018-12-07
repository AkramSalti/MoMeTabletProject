using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CardboardPrefabHolder", menuName = "Cardboard/CardboardPrefabHolder", order = 1)]
public class CardboardPrefabHolder : ScriptableObject {

    //This way we can reference to the cardboard prefab from the cardboard, and not the actual instance.
    public GameObject prefab;
}
