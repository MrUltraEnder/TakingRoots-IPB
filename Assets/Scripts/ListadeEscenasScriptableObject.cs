using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
[CreateAssetMenu(fileName = "ListadeEscenas", menuName = "ListadeEscenas")]
public class ListadeEscenasScriptableObject : ScriptableObject
{
    public List<string> scenes;

}
