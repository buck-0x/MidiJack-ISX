using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

namespace MidiJackISX
{
    [InitializeOnLoad]
    public class RemapInputProcessor : InputProcessor<float>
    {
        public float min = -1f;
        public float max = 1f;

        static RemapInputProcessor()
        {
            InputSystem.RegisterControlProcessor<RemapInputProcessor>();
        }

        [RuntimeInitializeOnLoadMethod]
        private static void Register() { }

        public override float Process(float value, InputControl<float> control)
        {
            return Mathf.Lerp(min, max, value);
        }
    }
}