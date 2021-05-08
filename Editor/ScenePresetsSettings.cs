using System;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace ScenePresets.Editor
{
    public class ScenePresetsSettings : ScriptableObject
    {
        [Serializable]
        public struct Preset
        {
            public string name;
            public SceneSetup[] scenes;
        }

        public List<Preset> presets;
    }
}