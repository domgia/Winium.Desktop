namespace Winium.Desktop.Driver.Input
{
    #region using

    using System.Collections.Generic;

    using OpenQA.Selenium;

    using WindowsInput.Native;

    #endregion

    internal class KeyboardModifiers : List<string>
    {
        #region Static Fields

        private static readonly List<string> Modifiers = new List<string>
                                                             {
                                                                 Keys.Control,
                                                                 Keys.LeftControl,
                                                                 Keys.Shift,
                                                                 Keys.LeftShift,
                                                                 Keys.Alt,
                                                                 Keys.LeftAlt

                                                             };


        private static readonly Dictionary<string, VirtualKeyCode> ModifiersMap =
            new Dictionary<string, VirtualKeyCode>
                {
                    { Keys.Control, VirtualKeyCode.CONTROL },
                    { Keys.Shift, VirtualKeyCode.SHIFT },
                    { Keys.Alt, VirtualKeyCode.MENU },
                    { Keys.ArrowUp, VirtualKeyCode.UP },
                    { Keys.ArrowLeft, VirtualKeyCode.LEFT },
                    { Keys.ArrowRight, VirtualKeyCode.RIGHT },
                    { Keys.ArrowDown, VirtualKeyCode.DOWN },
                    { Keys.PageUp, VirtualKeyCode.PRIOR },
                    { Keys.PageDown, VirtualKeyCode.NEXT },
                    { Keys.Enter, VirtualKeyCode.RETURN },
                    { Keys.Escape, VirtualKeyCode.ESCAPE },
                    { Keys.Space, VirtualKeyCode.SPACE },
                    { Keys.Backspace, VirtualKeyCode.BACK },
                    { Keys.Insert, VirtualKeyCode.INSERT },
                    { Keys.Home, VirtualKeyCode.HOME },
                    { Keys.Delete, VirtualKeyCode.DELETE },
                    { Keys.End, VirtualKeyCode.END },
                    { Keys.Divide, VirtualKeyCode.DIVIDE },
                    { Keys.Subtract, VirtualKeyCode.SUBTRACT },
                    { Keys.Add, VirtualKeyCode.ADD },
                    { Keys.Tab, VirtualKeyCode.TAB },
                    { Keys.Decimal, VirtualKeyCode.DECIMAL },
                    { Keys.Multiply, VirtualKeyCode.MULTIPLY },
                    { Keys.Separator, VirtualKeyCode.SEPARATOR },
                    {"a", VirtualKeyCode.VK_A },
                    {"b", VirtualKeyCode.VK_B },
                    {"c", VirtualKeyCode.VK_C },
                    {"d", VirtualKeyCode.VK_D },
                    {"e", VirtualKeyCode.VK_E },
                    {"f", VirtualKeyCode.VK_F },
                    {"g", VirtualKeyCode.VK_G },
                    {"h", VirtualKeyCode.VK_H },
                    {"i", VirtualKeyCode.VK_I },
                    {"j", VirtualKeyCode.VK_J },
                    {"k", VirtualKeyCode.VK_K },
                    {"l", VirtualKeyCode.VK_L },
                    {"m", VirtualKeyCode.VK_M },
                    {"n", VirtualKeyCode.VK_N },
                    {"o", VirtualKeyCode.VK_O },
                    {"p", VirtualKeyCode.VK_P },
                    {"q", VirtualKeyCode.VK_Q },
                    {"r", VirtualKeyCode.VK_R },
                    {"s", VirtualKeyCode.VK_S },
                    {"t", VirtualKeyCode.VK_T },
                    {"u", VirtualKeyCode.VK_U },
                    {"v", VirtualKeyCode.VK_V },
                    {"w", VirtualKeyCode.VK_W },
                    {"x", VirtualKeyCode.VK_X },
                    {"y", VirtualKeyCode.VK_Y },
                    {"z", VirtualKeyCode.VK_Z },
                    { "0", VirtualKeyCode.VK_0 },
                    { "1", VirtualKeyCode.VK_1 },
                    { "2", VirtualKeyCode.VK_2 },
                    { "3", VirtualKeyCode.VK_3 },
                    { "4", VirtualKeyCode.VK_4 },
                    { "5", VirtualKeyCode.VK_5 },
                    { "6", VirtualKeyCode.VK_6 },
                    { "7", VirtualKeyCode.VK_7 },
                    { "8", VirtualKeyCode.VK_8 },
                    { "9", VirtualKeyCode.VK_9 },
                    { Keys.F1, VirtualKeyCode.F1 },
                    { Keys.F2, VirtualKeyCode.F2 },
                    { Keys.F3, VirtualKeyCode.F3 },
                    { Keys.F4, VirtualKeyCode.F4 },
                    { Keys.F5, VirtualKeyCode.F5 },
                    { Keys.F6, VirtualKeyCode.F6 },
                    { Keys.F7, VirtualKeyCode.F7 },
                    { Keys.F8, VirtualKeyCode.F8 },
                    { Keys.F9, VirtualKeyCode.F9 },
                    { Keys.F10, VirtualKeyCode.F10 },
                    { Keys.F11, VirtualKeyCode.F11 },
                    { Keys.F12, VirtualKeyCode.F12 }
                };

        #endregion

        #region Public Methods and Operators

        public static string GetKeyFromUnicode(char key)
        {
            return Modifiers.Find(modifier => modifier[0] == key);
        }



        public static VirtualKeyCode GetVirtualKeyCode(string key)
        {
            VirtualKeyCode virtualKey;

            if (ModifiersMap.TryGetValue(key, out virtualKey))
            {
                return virtualKey;
            }

            return default(VirtualKeyCode);
        }

        public static bool IsModifier(string key)
        {
            return Modifiers.Contains(key);
        }

        public static bool IsKeyMapped(string key)
        {
            return ModifiersMap.ContainsKey(key);
        }

        #endregion
    }
}
