
using UnityEngine;
using UnityEngine.InputSystem;

public class BindingSaveLoad : MonoBehaviour
{
    public InputActionAsset _inputActionAssetRace;
    public InputActionAsset _inputActionAssetStore;

    private void OnEnable()
    {
        var rebindsRace = PlayerPrefs.GetString("rebindsRace");
        if (!string.IsNullOrEmpty(rebindsRace))
        {
            _inputActionAssetRace.LoadBindingOverridesFromJson(rebindsRace);
        }
        var rebindsStore = PlayerPrefs.GetString("rebindsStore");
        if (!string.IsNullOrEmpty(rebindsStore))
            _inputActionAssetStore.LoadBindingOverridesFromJson(rebindsStore);
    }
    private void OnDisable()
    {
        var rebinds = _inputActionAssetRace.SaveBindingOverridesAsJson();
        PlayerPrefs.SetString("rebindsRace", rebinds);
        rebinds = _inputActionAssetStore.SaveBindingOverridesAsJson();
        PlayerPrefs.SetString("rebindsStore", rebinds);
    }

}
