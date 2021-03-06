// Copyright (c) Xenko contributors (https://xenko.com) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.
using System;
using System.Linq;
using System.Windows;

namespace Xenko.Core.Presentation.Graph
{
    /// <summary>
    /// 
    /// </summary>
    public class LinkSelectedEventArgs : EventArgs
    {
        public FrameworkElement Link { get; private set; }

        public LinkSelectedEventArgs(FrameworkElement link)
            : base()
        {
            Link = link;
        }
    }

    public delegate void LinkSelectedEventHandler(object sender, LinkSelectedEventArgs args);
}
