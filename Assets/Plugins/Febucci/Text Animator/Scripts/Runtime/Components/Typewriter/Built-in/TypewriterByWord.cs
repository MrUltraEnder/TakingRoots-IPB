using UnityEngine;

namespace Febucci.UI
{
    [AddComponentMenu("Febucci/TextAnimator/Typewriter - By Word")]
    public class TypewriterByWord: Core.TypewriterCore
    {
        [SerializeField, Attributes.CharsDisplayTime] float waitForNormalWord = 0.3f;
        [SerializeField, Attributes.CharsDisplayTime] float waitForWordWithPuntuaction = 0.5f;
        [SerializeField, Attributes.CharsDisplayTime] float disappearanceDelay = 0.5f;
        
        bool IsCharInsideAnyWord(int charIndex)
        {
            return TextAnimator.Characters[charIndex].wordIndex >= 0;
        }

        protected override float GetWaitAppearanceTimeOf(int charIndex)
        {
            if (!IsCharInsideAnyWord(charIndex) && TextAnimator.latestCharacterShown.index>0)
            {
                int latestWordShownIndex = TextAnimator.Characters[TextAnimator.latestCharacterShown.index-1].wordIndex;
                if (latestWordShownIndex >= 0 && latestWordShownIndex < TextAnimator.WordsCount)
                {
                    var word = TextAnimator.Words[latestWordShownIndex];
                    return char.IsPunctuation(TextAnimator.Characters[word.lastCharacterIndex].info.character)
                        ? waitForWordWithPuntuaction
                        : waitForNormalWord;
                }

                return waitForNormalWord;
            }

            return 0;
        }

        protected override float GetWaitDisappearanceTimeOf(int charIndex)
        {
            return !IsCharInsideAnyWord(charIndex) ? disappearanceDelay : 0;
        }
    }
}