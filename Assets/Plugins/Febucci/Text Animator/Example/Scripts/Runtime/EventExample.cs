using Febucci.UI.Core;
using Febucci.UI.Core.Parsing;
using UnityEngine;

namespace Febucci.UI.Examples
{
    //Prevents this example to show up in the inspector
    [AddComponentMenu("")]
    public class EventExample : MonoBehaviour
    {
        public TypewriterCore typewriter;


        public Camera cam;


        int lastBGIndex;
        public Color[] bgColors;

        private void Awake()
        {
            UnityEngine.Assertions.Assert.IsNotNull(typewriter, $"Text Animator Player component is null in {gameObject.name}");
            typewriter.onMessage.AddListener(OnEvent);
        }

        void OnEvent(EventMarker marker)
        {
            switch (marker.name)
            {
                case "bg":
                    cam.backgroundColor = bgColors[lastBGIndex];
                    lastBGIndex++;
                    if (lastBGIndex >= bgColors.Length)
                        lastBGIndex = 0;
                    break;
            }
        }
    }
}