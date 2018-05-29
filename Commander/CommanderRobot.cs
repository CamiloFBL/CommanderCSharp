using System;
using System.Diagnostics;
using System.Linq;
using WindowsInput;
using WindowsInput.Native;

namespace Commander
{
    internal class CommanderRobot
    {
        public static String[] allowedKeys = new String[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "f1", "f2", "f3", "f4", "f5", "f6", "f7", "f8", "f9", "f10", "f11", "f12", "f13", "f14", "f15", "f16", "f17", "f18", "f19", "f20", "f21", "f22", "f23", "f24", "windows", "context", "up", "down", "left", "right", "esc", "enter", "backspace", "tab", "shift", "ctrl", "alt", "prtscreen", "caps", "numlock", "home", "insert", "end", "pgdown", "pgup", "del" };
        public static String[] allowedKeysDesc = new String[] { "A button key press.", "B button key press.", "C button key press.", "D button key press.", "E button key press.", "F button key press.", "G button key press.", "H button key press.", "I button key press.", "J button key press.", "K button key press.", "L button key press.", "M button key press.", "N button key press.", "O button key press.", "P button key press.", "Q button key press.", "R button key press.", "S button key press.", "T button key press.", "U button key press.", "V button key press.", "W button key press.", "X button key press.", "Y button key press.", "Z button key press.", "0 button key press.", "1 button key press.", "2 button key press.", "3 button key press.", "4 button key press.", "5 button key press.", "6 button key press.", "7 button key press.", "8 button key press.", "9 button key press.", "F1 button key press.", "F2 button key press.", "F3 button key press.", "F4 button key press.", "F5 button key press.", "F6 button key press.", "F7 button key press.", "F8 button key press.", "F9 button key press.", "F10 button key press.", "F11 button key press.", "F12 button key press.", "F13 button key press.", "F14 button key press.", "F15 button key press.", "F16 button key press.", "F17 button key press.", "F18 button key press.", "F19 button key press.", "F20 button key press.", "F21 button key press.", "F22 button key press.", "F23 button key press.", "F24 button key press.", "Windows button key press (Windows OS only).", "Context menu key press (Windows OS only).", "UP arrow button key press", "DOWN arrow button key press.", "LEFT arrow button key press.", "RIGHT arrow button key press.", "ESCAPE button key press.", "ENTER button key press.", "BACKSPACE button key press.", "TAB button key press.", "SHIFT button key press.", "CONTROL button key press.", "ALT button key press.", "PRINT SCREEN button key press.", "CAPS LOCK button key press.", "NUM LOCK button key press.", "HOME button key press.", "INSERT button key press.", "END button key press.", "PAGE DOWN button key press.", "PAGE UP button key press.", "DELETE button key press" };

        internal static void RobotKeyPress(string KeyPress)
        {
            InputSimulator press = new InputSimulator();

            if (KeyPress.Equals("a"))
                press.Keyboard.KeyDown((VirtualKeyCode.VK_A));
            if (KeyPress.Equals("b"))
                press.Keyboard.KeyDown((VirtualKeyCode.VK_B));
            if (KeyPress.Equals("c"))
                press.Keyboard.KeyDown((VirtualKeyCode.VK_C));
            if (KeyPress.Equals("d"))
                press.Keyboard.KeyDown((VirtualKeyCode.VK_D));
            if (KeyPress.Equals("e"))
                press.Keyboard.KeyDown((VirtualKeyCode.VK_E));
            if (KeyPress.Equals("f"))
                press.Keyboard.KeyDown((VirtualKeyCode.VK_F));
            if (KeyPress.Equals("g"))
                press.Keyboard.KeyDown((VirtualKeyCode.VK_G));
            if (KeyPress.Equals("h"))
                press.Keyboard.KeyDown((VirtualKeyCode.VK_H));
            if (KeyPress.Equals("i"))
                press.Keyboard.KeyDown((VirtualKeyCode.VK_I));
            if (KeyPress.Equals("j"))
                press.Keyboard.KeyDown((VirtualKeyCode.VK_J));
            if (KeyPress.Equals("k"))
                press.Keyboard.KeyDown((VirtualKeyCode.VK_K));
            if (KeyPress.Equals("l"))
                press.Keyboard.KeyDown((VirtualKeyCode.VK_L));
            if (KeyPress.Equals("m"))
                press.Keyboard.KeyDown((VirtualKeyCode.VK_M));
            if (KeyPress.Equals("n"))
                press.Keyboard.KeyDown((VirtualKeyCode.VK_N));
            if (KeyPress.Equals("o"))
                press.Keyboard.KeyDown((VirtualKeyCode.VK_O));
            if (KeyPress.Equals("p"))
                press.Keyboard.KeyDown((VirtualKeyCode.VK_P));
            if (KeyPress.Equals("q"))
                press.Keyboard.KeyDown((VirtualKeyCode.VK_Q));
            if (KeyPress.Equals("r"))
                press.Keyboard.KeyDown((VirtualKeyCode.VK_R));
            if (KeyPress.Equals("s"))
                press.Keyboard.KeyDown((VirtualKeyCode.VK_S));
            if (KeyPress.Equals("t"))
                press.Keyboard.KeyDown((VirtualKeyCode.VK_T));
            if (KeyPress.Equals("u"))
                press.Keyboard.KeyDown((VirtualKeyCode.VK_U));
            if (KeyPress.Equals("v"))
                press.Keyboard.KeyDown((VirtualKeyCode.VK_V));
            if (KeyPress.Equals("w"))
                press.Keyboard.KeyDown((VirtualKeyCode.VK_W));
            if (KeyPress.Equals("x"))
                press.Keyboard.KeyDown((VirtualKeyCode.VK_X));
            if (KeyPress.Equals("y"))
                press.Keyboard.KeyDown((VirtualKeyCode.VK_Y));
            if (KeyPress.Equals("z"))
                press.Keyboard.KeyDown((VirtualKeyCode.VK_Z));
            if (KeyPress.Equals("0"))
                press.Keyboard.KeyDown((VirtualKeyCode.VK_0));
            if (KeyPress.Equals("1"))
                press.Keyboard.KeyDown((VirtualKeyCode.VK_1));
            if (KeyPress.Equals("2"))
                press.Keyboard.KeyDown((VirtualKeyCode.VK_2));
            if (KeyPress.Equals("3"))
                press.Keyboard.KeyDown((VirtualKeyCode.VK_3));
            if (KeyPress.Equals("4"))
                press.Keyboard.KeyDown((VirtualKeyCode.VK_4));
            if (KeyPress.Equals("5"))
                press.Keyboard.KeyDown((VirtualKeyCode.VK_5));
            if (KeyPress.Equals("6"))
                press.Keyboard.KeyDown((VirtualKeyCode.VK_6));
            if (KeyPress.Equals("7"))
                press.Keyboard.KeyDown((VirtualKeyCode.VK_7));
            if (KeyPress.Equals("8"))
                press.Keyboard.KeyDown((VirtualKeyCode.VK_8));
            if (KeyPress.Equals("9"))
                press.Keyboard.KeyDown((VirtualKeyCode.VK_9));
            if (KeyPress.Equals("f1"))
                press.Keyboard.KeyDown((VirtualKeyCode.F1));
            if (KeyPress.Equals("f2"))
                press.Keyboard.KeyDown((VirtualKeyCode.F2));
            if (KeyPress.Equals("f3"))
                press.Keyboard.KeyDown((VirtualKeyCode.F3));
            if (KeyPress.Equals("f4"))
                press.Keyboard.KeyDown((VirtualKeyCode.F4));
            if (KeyPress.Equals("f5"))
                press.Keyboard.KeyDown((VirtualKeyCode.F5));
            if (KeyPress.Equals("f6"))
                press.Keyboard.KeyDown((VirtualKeyCode.F6));
            if (KeyPress.Equals("f7"))
                press.Keyboard.KeyDown((VirtualKeyCode.F7));
            if (KeyPress.Equals("f8"))
                press.Keyboard.KeyDown((VirtualKeyCode.F8));
            if (KeyPress.Equals("f9"))
                press.Keyboard.KeyDown((VirtualKeyCode.F9));
            if (KeyPress.Equals("f10"))
                press.Keyboard.KeyDown((VirtualKeyCode.F10));
            if (KeyPress.Equals("f11"))
                press.Keyboard.KeyDown((VirtualKeyCode.F11));
            if (KeyPress.Equals("f12"))
                press.Keyboard.KeyDown((VirtualKeyCode.F12));
            if (KeyPress.Equals("f13"))
                press.Keyboard.KeyDown((VirtualKeyCode.F13));
            if (KeyPress.Equals("f14"))
                press.Keyboard.KeyDown((VirtualKeyCode.F14));
            if (KeyPress.Equals("f15"))
                press.Keyboard.KeyDown((VirtualKeyCode.F15));
            if (KeyPress.Equals("f16"))
                press.Keyboard.KeyDown((VirtualKeyCode.F16));
            if (KeyPress.Equals("f17"))
                press.Keyboard.KeyDown((VirtualKeyCode.F17));
            if (KeyPress.Equals("f18"))
                press.Keyboard.KeyDown((VirtualKeyCode.F18));
            if (KeyPress.Equals("f19"))
                press.Keyboard.KeyDown((VirtualKeyCode.F19));
            if (KeyPress.Equals("f20"))
                press.Keyboard.KeyDown((VirtualKeyCode.F20));
            if (KeyPress.Equals("f21"))
                press.Keyboard.KeyDown((VirtualKeyCode.F21));
            if (KeyPress.Equals("f22"))
                press.Keyboard.KeyDown((VirtualKeyCode.F22));
            if (KeyPress.Equals("f23"))
                press.Keyboard.KeyDown((VirtualKeyCode.F23));
            if (KeyPress.Equals("f24"))
                press.Keyboard.KeyDown((VirtualKeyCode.F24));
            if (KeyPress.Equals("windows"))
                press.Keyboard.KeyDown((VirtualKeyCode.RWIN));
            if (KeyPress.Equals("context"))
                press.Keyboard.KeyDown((VirtualKeyCode.RMENU));
            if (KeyPress.Equals("up"))
                press.Keyboard.KeyDown((VirtualKeyCode.UP));
            if (KeyPress.Equals("down"))
                press.Keyboard.KeyDown((VirtualKeyCode.DOWN));
            if (KeyPress.Equals("left"))
                press.Keyboard.KeyDown((VirtualKeyCode.LEFT));
            if (KeyPress.Equals("right"))
                press.Keyboard.KeyDown((VirtualKeyCode.RIGHT));
            if (KeyPress.Equals("esc"))
                press.Keyboard.KeyDown((VirtualKeyCode.ESCAPE));
            if (KeyPress.Equals("enter"))
                press.Keyboard.KeyDown((VirtualKeyCode.RETURN));
            if (KeyPress.Equals("backspace"))
                press.Keyboard.KeyDown((VirtualKeyCode.BACK));
            if (KeyPress.Equals("tab"))
                press.Keyboard.KeyDown((VirtualKeyCode.TAB));
            if (KeyPress.Equals("shift"))
                press.Keyboard.KeyDown((VirtualKeyCode.SHIFT));
            if (KeyPress.Equals("ctrl"))
                press.Keyboard.KeyDown((VirtualKeyCode.CONTROL));
            if (KeyPress.Equals("alt"))
                press.Keyboard.KeyDown((VirtualKeyCode.MENU));
            if (KeyPress.Equals("prtscreen"))
                press.Keyboard.KeyDown((VirtualKeyCode.SNAPSHOT));
            if (KeyPress.Equals("caps"))
                press.Keyboard.KeyDown((VirtualKeyCode.CAPITAL));
            if (KeyPress.Equals("numlock"))
                press.Keyboard.KeyDown((VirtualKeyCode.NUMLOCK));
            if (KeyPress.Equals("home"))
                press.Keyboard.KeyDown((VirtualKeyCode.HOME));
            if (KeyPress.Equals("insert"))
                press.Keyboard.KeyDown((VirtualKeyCode.INSERT));
            if (KeyPress.Equals("end"))
                press.Keyboard.KeyDown((VirtualKeyCode.END));
            if (KeyPress.Equals("pgdown"))
                press.Keyboard.KeyDown((VirtualKeyCode.PRIOR));
            if (KeyPress.Equals("pgup"))
                press.Keyboard.KeyDown((VirtualKeyCode.NEXT));
            if (KeyPress.Equals("del"))
                press.Keyboard.KeyDown((VirtualKeyCode.DELETE));
        }

        internal static void RobotKeyRelease(string KeyPress)
        {
            InputSimulator release = new InputSimulator();
            if (KeyPress.Equals("a"))
                release.Keyboard.KeyUp((VirtualKeyCode.VK_A));
            if (KeyPress.Equals("b"))
                release.Keyboard.KeyUp((VirtualKeyCode.VK_B));
            if (KeyPress.Equals("c"))
                release.Keyboard.KeyUp((VirtualKeyCode.VK_C));
            if (KeyPress.Equals("d"))
                release.Keyboard.KeyUp((VirtualKeyCode.VK_D));
            if (KeyPress.Equals("e"))
                release.Keyboard.KeyUp((VirtualKeyCode.VK_E));
            if (KeyPress.Equals("f"))
                release.Keyboard.KeyUp((VirtualKeyCode.VK_F));
            if (KeyPress.Equals("g"))
                release.Keyboard.KeyUp((VirtualKeyCode.VK_G));
            if (KeyPress.Equals("h"))
                release.Keyboard.KeyUp((VirtualKeyCode.VK_H));
            if (KeyPress.Equals("i"))
                release.Keyboard.KeyUp((VirtualKeyCode.VK_I));
            if (KeyPress.Equals("j"))
                release.Keyboard.KeyUp((VirtualKeyCode.VK_J));
            if (KeyPress.Equals("k"))
                release.Keyboard.KeyUp((VirtualKeyCode.VK_K));
            if (KeyPress.Equals("l"))
                release.Keyboard.KeyUp((VirtualKeyCode.VK_L));
            if (KeyPress.Equals("m"))
                release.Keyboard.KeyUp((VirtualKeyCode.VK_M));
            if (KeyPress.Equals("n"))
                release.Keyboard.KeyUp((VirtualKeyCode.VK_N));
            if (KeyPress.Equals("o"))
                release.Keyboard.KeyUp((VirtualKeyCode.VK_O));
            if (KeyPress.Equals("p"))
                release.Keyboard.KeyUp((VirtualKeyCode.VK_P));
            if (KeyPress.Equals("q"))
                release.Keyboard.KeyUp((VirtualKeyCode.VK_Q));
            if (KeyPress.Equals("r"))
                release.Keyboard.KeyUp((VirtualKeyCode.VK_R));
            if (KeyPress.Equals("s"))
                release.Keyboard.KeyUp((VirtualKeyCode.VK_S));
            if (KeyPress.Equals("t"))
                release.Keyboard.KeyUp((VirtualKeyCode.VK_T));
            if (KeyPress.Equals("u"))
                release.Keyboard.KeyUp((VirtualKeyCode.VK_U));
            if (KeyPress.Equals("v"))
                release.Keyboard.KeyUp((VirtualKeyCode.VK_V));
            if (KeyPress.Equals("w"))
                release.Keyboard.KeyUp((VirtualKeyCode.VK_W));
            if (KeyPress.Equals("x"))
                release.Keyboard.KeyUp((VirtualKeyCode.VK_X));
            if (KeyPress.Equals("y"))
                release.Keyboard.KeyUp((VirtualKeyCode.VK_Y));
            if (KeyPress.Equals("z"))
                release.Keyboard.KeyUp((VirtualKeyCode.VK_Z));
            if (KeyPress.Equals("0"))
                release.Keyboard.KeyUp((VirtualKeyCode.VK_0));
            if (KeyPress.Equals("1"))
                release.Keyboard.KeyUp((VirtualKeyCode.VK_1));
            if (KeyPress.Equals("2"))
                release.Keyboard.KeyUp((VirtualKeyCode.VK_2));
            if (KeyPress.Equals("3"))
                release.Keyboard.KeyUp((VirtualKeyCode.VK_3));
            if (KeyPress.Equals("4"))
                release.Keyboard.KeyUp((VirtualKeyCode.VK_4));
            if (KeyPress.Equals("5"))
                release.Keyboard.KeyUp((VirtualKeyCode.VK_5));
            if (KeyPress.Equals("6"))
                release.Keyboard.KeyUp((VirtualKeyCode.VK_6));
            if (KeyPress.Equals("7"))
                release.Keyboard.KeyUp((VirtualKeyCode.VK_7));
            if (KeyPress.Equals("8"))
                release.Keyboard.KeyUp((VirtualKeyCode.VK_8));
            if (KeyPress.Equals("9"))
                release.Keyboard.KeyUp((VirtualKeyCode.VK_9));
            if (KeyPress.Equals("f1"))
                release.Keyboard.KeyUp((VirtualKeyCode.F1));
            if (KeyPress.Equals("f2"))
                release.Keyboard.KeyUp((VirtualKeyCode.F2));
            if (KeyPress.Equals("f3"))
                release.Keyboard.KeyUp((VirtualKeyCode.F3));
            if (KeyPress.Equals("f4"))
                release.Keyboard.KeyUp((VirtualKeyCode.F4));
            if (KeyPress.Equals("f5"))
                release.Keyboard.KeyUp((VirtualKeyCode.F5));
            if (KeyPress.Equals("f6"))
                release.Keyboard.KeyUp((VirtualKeyCode.F6));
            if (KeyPress.Equals("f7"))
                release.Keyboard.KeyUp((VirtualKeyCode.F7));
            if (KeyPress.Equals("f8"))
                release.Keyboard.KeyUp((VirtualKeyCode.F8));
            if (KeyPress.Equals("f9"))
                release.Keyboard.KeyUp((VirtualKeyCode.F9));
            if (KeyPress.Equals("f10"))
                release.Keyboard.KeyUp((VirtualKeyCode.F10));
            if (KeyPress.Equals("f11"))
                release.Keyboard.KeyUp((VirtualKeyCode.F11));
            if (KeyPress.Equals("f12"))
                release.Keyboard.KeyUp((VirtualKeyCode.F12));
            if (KeyPress.Equals("f13"))
                release.Keyboard.KeyUp((VirtualKeyCode.F13));
            if (KeyPress.Equals("f14"))
                release.Keyboard.KeyUp((VirtualKeyCode.F14));
            if (KeyPress.Equals("f15"))
                release.Keyboard.KeyUp((VirtualKeyCode.F15));
            if (KeyPress.Equals("f16"))
                release.Keyboard.KeyUp((VirtualKeyCode.F16));
            if (KeyPress.Equals("f17"))
                release.Keyboard.KeyUp((VirtualKeyCode.F17));
            if (KeyPress.Equals("f18"))
                release.Keyboard.KeyUp((VirtualKeyCode.F18));
            if (KeyPress.Equals("f19"))
                release.Keyboard.KeyUp((VirtualKeyCode.F19));
            if (KeyPress.Equals("f20"))
                release.Keyboard.KeyUp((VirtualKeyCode.F20));
            if (KeyPress.Equals("f21"))
                release.Keyboard.KeyUp((VirtualKeyCode.F21));
            if (KeyPress.Equals("f22"))
                release.Keyboard.KeyUp((VirtualKeyCode.F22));
            if (KeyPress.Equals("f23"))
                release.Keyboard.KeyUp((VirtualKeyCode.F23));
            if (KeyPress.Equals("f24"))
                release.Keyboard.KeyUp((VirtualKeyCode.F24));
            if (KeyPress.Equals("windows"))
                release.Keyboard.KeyUp((VirtualKeyCode.RWIN));
            if (KeyPress.Equals("context"))
                release.Keyboard.KeyUp((VirtualKeyCode.RMENU));
            if (KeyPress.Equals("up"))
                release.Keyboard.KeyUp((VirtualKeyCode.UP));
            if (KeyPress.Equals("down"))
                release.Keyboard.KeyUp((VirtualKeyCode.DOWN));
            if (KeyPress.Equals("left"))
                release.Keyboard.KeyUp((VirtualKeyCode.LEFT));
            if (KeyPress.Equals("right"))
                release.Keyboard.KeyUp((VirtualKeyCode.RIGHT));
            if (KeyPress.Equals("esc"))
                release.Keyboard.KeyUp((VirtualKeyCode.ESCAPE));
            if (KeyPress.Equals("enter"))
                release.Keyboard.KeyUp((VirtualKeyCode.RETURN));
            if (KeyPress.Equals("backspace"))
                release.Keyboard.KeyUp((VirtualKeyCode.BACK));
            if (KeyPress.Equals("tab"))
                release.Keyboard.KeyUp((VirtualKeyCode.TAB));
            if (KeyPress.Equals("shift"))
                release.Keyboard.KeyUp((VirtualKeyCode.SHIFT));
            if (KeyPress.Equals("ctrl"))
                release.Keyboard.KeyUp((VirtualKeyCode.CONTROL));
            if (KeyPress.Equals("alt"))
                release.Keyboard.KeyUp((VirtualKeyCode.MENU));
            if (KeyPress.Equals("prtscreen"))
                release.Keyboard.KeyUp((VirtualKeyCode.SNAPSHOT));
            if (KeyPress.Equals("caps"))
                release.Keyboard.KeyUp((VirtualKeyCode.CAPITAL));
            if (KeyPress.Equals("numlock"))
                release.Keyboard.KeyUp((VirtualKeyCode.NUMLOCK));
            if (KeyPress.Equals("home"))
                release.Keyboard.KeyUp((VirtualKeyCode.HOME));
            if (KeyPress.Equals("insert"))
                release.Keyboard.KeyUp((VirtualKeyCode.INSERT));
            if (KeyPress.Equals("end"))
                release.Keyboard.KeyUp((VirtualKeyCode.END));
            if (KeyPress.Equals("pgdown"))
                release.Keyboard.KeyUp((VirtualKeyCode.PRIOR));
            if (KeyPress.Equals("pgup"))
                release.Keyboard.KeyUp((VirtualKeyCode.NEXT));
            if (KeyPress.Equals("del"))
                release.Keyboard.KeyUp((VirtualKeyCode.DELETE));
        }

        internal static void RobotExecApp(string command)
        {
            try
            {
                int commIndex = Array.IndexOf(CommanderFunctions.commNamesByApps, command);
                String appPath = CommanderFunctions.commAppsPath[commIndex];

                Process.Start(appPath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        internal static bool KeysCheck(object validateComm)
        {
            String[] keys;
            String keysString = validateComm.ToString();
            keys = keysString.Split('+');
            for (int i = 0; i < keys.Length; i++)
            {
                String key = keys[i];
                Console.WriteLine(key);

                if (!allowedKeys.Contains(key))
                {
                    return false;
                }
            }

            return true;
        }
    }
}