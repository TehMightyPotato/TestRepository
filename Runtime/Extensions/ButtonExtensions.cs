using System;
using UI;
using UnityEngine.UIElements;

namespace Extensions
{
    public static class ButtonExtensions
    {
        public static void InitializeButton(this Button button, Action callback)
        {
            button.clicked += callback;
            CanvasManager.Instance.RegisterButtonSfx(button);
            //AAAA
        }
    }
}