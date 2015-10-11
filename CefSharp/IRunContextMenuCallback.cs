﻿// Copyright © 2010-2015 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

namespace CefSharp
{
    public interface IRunContextMenuCallback
    {
        /// <summary>
        /// Complete context menu display by selecting the specified commandId and eventFlags;
        /// </summary>
        /// <param name="commandId">the command Id</param>
        /// <param name="eventFlags">the event flags</param>
        void Continue(CefMenuCommand commandId, CefEventFlags eventFlags);

        /// <summary>
        /// Cancel context menu display.
        /// </summary>
        void Cancel();
    }
}
