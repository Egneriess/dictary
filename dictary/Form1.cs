using System.Runtime.InteropServices;
using System.Text;

namespace dictary
{
    public partial class Form1 : Form
    {
        Point p;
        [DllImport("user32", CharSet = CharSet.Unicode)]
        private static extern IntPtr WindowFromPoint(Point Point);
        [DllImport("user32", SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);
        [DllImport("user32", CharSet = CharSet.Unicode)]
        private static extern int GetClassName(IntPtr hWnd, StringBuilder lpString, int nMaxCount);
        [DllImport("user32", CharSet = CharSet.Unicode)]
        private static extern int GetParent(IntPtr hWnd);
        [DllImport("user32", CharSet = CharSet.Unicode)]
        private static extern int GetCursorPos(ref Point lpPoint);
        [DllImport("user32", CharSet = CharSet.Unicode)]
        private static extern int IsWindowEnabled(IntPtr hWnd);
        [DllImport("user32", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);
        public Form1()
        {
            InitializeComponent();
        }

        private void get_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Cross;
        }

        private void get_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Default;
            GetCursorPos(ref p);
            handle.Text = WindowFromPoint(p).ToString();
            StringBuilder t = new(256);
            GetWindowText(WindowFromPoint(p), t, t.Capacity);
            title.Text = t.ToString();
            t = new(256);
            GetClassName(WindowFromPoint(p), t, t.Capacity);
            Class.Text = t.ToString();
            parent.Text = GetParent(WindowFromPoint(p)).ToString();
            t = new(256);
            GetClassName((IntPtr)GetParent(WindowFromPoint(p)), t, t.Capacity);
            parentclass.Text = t.ToString();
            t = new(256);
            GetWindowText(WindowFromPoint(p), t, t.Capacity);
            parenttext.Text = t.ToString();
            uint id = GetWindowThreadProcessId(WindowFromPoint(p), out uint procId);
            ID.Text = procId.ToString() + ", " + id.ToString();
            cursor.Text = p.ToString();
        }
        public static string ConvertRGBToHex(int r, int g, int b)
        {
            string rFString, rSString, gFString, gSString, bFString, bSString, result;
            int red, green, blue, rred, rgreen, rblue;
            red = r / 16;
            rred = r % 16;
            if (red == 10) rFString = "A";
            else if (red == 11) rFString = "B";
            else if (red == 12) rFString = "C";
            else if (red == 13) rFString = "D";
            else if (red == 14) rFString = "E";
            else if (red == 15) rFString = "F";
            else rFString = red.ToString();

            if (rred == 10) rSString = "A";
            else if (rred == 11) rSString = "B";
            else if (rred == 12) rSString = "C";
            else if (rred == 13) rSString = "D";
            else if (rred == 14) rSString = "E";
            else if (rred == 15) rSString = "F";
            else rSString = rred.ToString();

            rFString += rSString;

            green = g / 16;
            rgreen = g % 16;

            if (green == 10) gFString = "A";
            else if (green == 11) gFString = "B";
            else if (green == 12) gFString = "C";
            else if (green == 13) gFString = "D";
            else if (green == 14) gFString = "E";
            else if (green == 15) gFString = "F";
            else gFString = green.ToString();

            if (rgreen == 10) gSString = "A";
            else if (rgreen == 11) gSString = "B";
            else if (rgreen == 12) gSString = "C";
            else if (rgreen == 13) gSString = "D";
            else if (rgreen == 14) gSString = "E";
            else if (rgreen == 15) gSString = "F";
            else gSString = rgreen.ToString();

            gFString += gSString;

            blue = b / 16;
            rblue = b % 16;

            if (blue == 10) bFString = "A";
            else if (blue == 11) bFString = "B";
            else if (blue == 12) bFString = "C";
            else if (blue == 13) bFString = "D";
            else if (blue == 14) bFString = "E";
            else if (blue == 15) bFString = "F";
            else bFString = blue.ToString();

            if (rblue == 10) bSString = "A";
            else if (rblue == 11) bSString = "B";
            else if (rblue == 12) bSString = "C";
            else if (rblue == 13) bSString = "D";
            else if (rblue == 14) bSString = "E";
            else if (rblue == 15) bSString = "F";
            else bSString = rblue.ToString();
            bFString += bSString;
            result = "#" + rFString + gFString + bFString;
            return result;
        }

        private void get_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Cross;
        }

        private void get_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Cross;
        }

        private void get_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}