using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace CounterApp.Editor
{

    public class EditorCounterApp : EditorWindow
    {
        [MenuItem("EditorConterApp/Open")]
        static void Open()
        {
            var window = GetWindow<EditorCounterApp>();
            window.position = new Rect(100, 100, 400, 600);
            window.titleContent = new GUIContent(nameof(EditorCounterApp));
            window.Show();

        }
        private void OnGUI()
        {
            if (GUILayout.Button("+"))
            {
                new AddCountCommand().Execute();
            }

            GUILayout.Label(CounterApp.Get<CounterModel>().Count.Value.ToString());

            if (GUILayout.Button("-"))
            {
                new SubCountCommand().Execute();
            }
            if (GUILayout.Button("X2"))
            {
                new MultiplyCommand().Execute();
            }
            if (GUILayout.Button("Return 0"))
            {
                new EliminateCommand().Execute();
            }
        }

    }
}
