﻿#pragma checksum "C:\Users\Dennis\Documents\GitHub\beem\Beem\StationPlayer.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "ADD7B3945E97CD2248FC06F02C438101"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Coding4Fun.Toolkit.Controls;
using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Beem {
    
    
    public partial class StationPlayer : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Coding4Fun.Toolkit.Controls.RoundButton btnPrevious;
        
        internal Coding4Fun.Toolkit.Controls.RoundButton btnPlay;
        
        internal Coding4Fun.Toolkit.Controls.RoundButton btnNext;
        
        internal Coding4Fun.Toolkit.Controls.RoundButton btnRecord;
        
        internal Coding4Fun.Toolkit.Controls.RoundButton btnRecordStop;
        
        internal System.Windows.Controls.StackPanel ContentPanel;
        
        internal System.Windows.Controls.Button btnMarket;
        
        internal System.Windows.Controls.Button btnPin;
        
        internal System.Windows.Controls.Button btnShare;
        
        internal System.Windows.Controls.Button btnCopy;
        
        internal System.Windows.Controls.Button btnFavorite;
        
        internal System.Windows.Controls.Image imgFave;
        
        internal System.Windows.Media.TranslateTransform NameTranslation;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Beem;component/StationPlayer.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.btnPrevious = ((Coding4Fun.Toolkit.Controls.RoundButton)(this.FindName("btnPrevious")));
            this.btnPlay = ((Coding4Fun.Toolkit.Controls.RoundButton)(this.FindName("btnPlay")));
            this.btnNext = ((Coding4Fun.Toolkit.Controls.RoundButton)(this.FindName("btnNext")));
            this.btnRecord = ((Coding4Fun.Toolkit.Controls.RoundButton)(this.FindName("btnRecord")));
            this.btnRecordStop = ((Coding4Fun.Toolkit.Controls.RoundButton)(this.FindName("btnRecordStop")));
            this.ContentPanel = ((System.Windows.Controls.StackPanel)(this.FindName("ContentPanel")));
            this.btnMarket = ((System.Windows.Controls.Button)(this.FindName("btnMarket")));
            this.btnPin = ((System.Windows.Controls.Button)(this.FindName("btnPin")));
            this.btnShare = ((System.Windows.Controls.Button)(this.FindName("btnShare")));
            this.btnCopy = ((System.Windows.Controls.Button)(this.FindName("btnCopy")));
            this.btnFavorite = ((System.Windows.Controls.Button)(this.FindName("btnFavorite")));
            this.imgFave = ((System.Windows.Controls.Image)(this.FindName("imgFave")));
            this.NameTranslation = ((System.Windows.Media.TranslateTransform)(this.FindName("NameTranslation")));
        }
    }
}

