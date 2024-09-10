// THIS FILE IS PART OF WinFormium PROJECT
// THE WinFormium PROJECT IS AN OPENSOURCE LIBRARY LICENSED UNDER THE MIT License.
// COPYRIGHTS (C) Xuanchen Lin. ALL RIGHTS RESERVED.
// GITHUB: https://github.com/XuanchenLin/NanUI

namespace WinFormium.Forms;

public class WindowActivatedEventArgs : EventArgs
{
    internal WindowActivatedEventArgs(bool state)
    {
        IsActivated = state;
    }

    public bool IsActivated { get; }
}
