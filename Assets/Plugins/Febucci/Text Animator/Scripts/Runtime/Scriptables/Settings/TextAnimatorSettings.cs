using Febucci.UI.Actions;
using Febucci.UI.Core;
using Febucci.UI.Core.Parsing;
using Febucci.UI.Effects;
using UnityEngine;

namespace Febucci.UI
{
    [System.Serializable]
    [CreateAssetMenu(fileName = "Text Animator Settings", menuName = "Text Animator/Settings", order = 100)]
    public sealed class TextAnimatorSettings : ScriptableObject
    {
        public const string expectedName = "TextAnimatorSettings";
        private static TextAnimatorSettings instance;
        public static TextAnimatorSettings Instance
        {
            get
            {
                if (instance) return instance;
                
                LoadSettings();
                return instance;
            }
        }
        
        public static void LoadSettings()
        {
            if(instance) return;
            instance = Resources.Load<TextAnimatorSettings>(expectedName);
        }

        public static void UnloadSettings()
        {
            if(!instance) return;
            
            Resources.UnloadAsset(instance);
            instance = null;
        }
        
        public static void SetAllEffectsActive(bool enabled)
        {
            SetAppearancesActive(enabled);
            SetBehaviorsActive(enabled);
        }

        public static void SetAppearancesActive(bool enabled)
        {
            if (Instance) Instance.appearances.enabled = enabled;
        }
        
        public static void SetBehaviorsActive(bool enabled)
        {
            if (Instance) Instance.behaviors.enabled = enabled;
        }
        
        [System.Serializable]
        public struct Category<T> where T : ScriptableObject
        {
            public T defaultDatabase;

            public bool enabled;
            public char openingSymbol;
            public char closingSymbol;
            
            public Category(char openingSymbol, char closingSymbol)
            {
                defaultDatabase = null;
                enabled = true;
                this.openingSymbol = openingSymbol;
                this.closingSymbol = closingSymbol;
            }
        }

        [Header("Default info")]
        public Category<AnimationsDatabase> behaviors = new Category<AnimationsDatabase>('<', '>');
        public Category<AnimationsDatabase> appearances = new Category<AnimationsDatabase>('{', '}');
        public Category<ActionDatabase> actions = new Category<ActionDatabase>('<', '>');
    }
}