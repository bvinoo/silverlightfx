﻿// MouseTrigger.cs
// Copyright (c) Nikhil Kothari, 2008. All Rights Reserved.
// http://www.nikhilk.net
//
// This product's copyrights are licensed under the Creative
// Commons Attribution-ShareAlike (version 2.5).B
// http://creativecommons.org/licenses/by-sa/2.5/
//
// Silverlight.FX is an application framework for building RIAs with Silverlight.
// This project is licensed under the BSD license. See the accompanying License.txt
// file for more information.
// For updated project information please visit http://projects.nikhilk.net/SilverlightFX.
//

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;

namespace SilverlightFX.UserInterface {

    /// <summary>
    /// A trigger that can be associated with an element to handle Mouse events.
    /// </summary>
    public sealed class MouseTrigger : EventTriggerBase<FrameworkElement> {

        private bool _mouseUp;

        /// <summary>
        /// Gets whether the associated action should be triggered when
        /// the mouse is pressed down or when the mouse is released.
        /// </summary>
        public bool MouseUp {
            get {
                return _mouseUp;
            }
            set {
                _mouseUp = value;
            }
        }

        /// <internalonly />
        protected override string GetEventName() {
            return _mouseUp ? "MouseLeftButtonUp" : "MouseLeftButtonDown";
        }
    }
}