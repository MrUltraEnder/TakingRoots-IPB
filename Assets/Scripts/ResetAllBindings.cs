
using UnityEngine;
using UnityEngine.InputSystem;

public class ResetAllBindings : MonoBehaviour
{
    [SerializeField] private InputActionAsset _inputActionAssetRace;
    [SerializeField] private InputActionAsset _inputActionAssetStore;
    public void ResetBindingsRace()
    {
        foreach (var item in _inputActionAssetRace.actionMaps)
        {
            item.RemoveAllBindingOverrides();
        }
        PlayerPrefs.DeleteKey("rebindsRace");

    }
    public void ResetBindingsStore()
    {
        foreach (var item in _inputActionAssetStore.actionMaps)
        {
            item.RemoveAllBindingOverrides();
        }
        PlayerPrefs.DeleteKey("rebindsStore");
    }
}
