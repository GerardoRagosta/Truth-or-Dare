﻿#pragma checksum "C:\Users\P£PP£\Documents\AresProject\Ares\Obbligo o verita\Obbligo o verita\Game.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D4D30040B91C019289A3863D5D825D9C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.34011
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Advertising.Mobile.UI;
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


namespace Obbligo_o_verita {
    
    
    public partial class Game : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Media.Animation.Storyboard Storyboard1;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Image bg;
        
        internal System.Windows.Controls.Image immagine;
        
        internal System.Windows.Controls.TextBlock instr;
        
        internal System.Windows.Controls.TextBlock nomeGioc;
        
        internal System.Windows.Controls.TextBlock done;
        
        internal System.Windows.Controls.TextBlock refused;
        
        internal System.Windows.Controls.TextBlock obbligo;
        
        internal System.Windows.Controls.TextBlock verita;
        
        internal System.Windows.Controls.Image a1;
        
        internal System.Windows.Controls.Image a2;
        
        internal System.Windows.Controls.Image a3;
        
        internal System.Windows.Controls.Image a4;
        
        internal System.Windows.Controls.Image a5;
        
        internal System.Windows.Controls.TextBlock ok;
        
        internal System.Windows.Controls.Grid griglia;
        
        internal Microsoft.Advertising.Mobile.UI.AdControl firstAd;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Obbligo%20o%20verita;component/Game.xaml", System.UriKind.Relative));
            this.Storyboard1 = ((System.Windows.Media.Animation.Storyboard)(this.FindName("Storyboard1")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.bg = ((System.Windows.Controls.Image)(this.FindName("bg")));
            this.immagine = ((System.Windows.Controls.Image)(this.FindName("immagine")));
            this.instr = ((System.Windows.Controls.TextBlock)(this.FindName("instr")));
            this.nomeGioc = ((System.Windows.Controls.TextBlock)(this.FindName("nomeGioc")));
            this.done = ((System.Windows.Controls.TextBlock)(this.FindName("done")));
            this.refused = ((System.Windows.Controls.TextBlock)(this.FindName("refused")));
            this.obbligo = ((System.Windows.Controls.TextBlock)(this.FindName("obbligo")));
            this.verita = ((System.Windows.Controls.TextBlock)(this.FindName("verita")));
            this.a1 = ((System.Windows.Controls.Image)(this.FindName("a1")));
            this.a2 = ((System.Windows.Controls.Image)(this.FindName("a2")));
            this.a3 = ((System.Windows.Controls.Image)(this.FindName("a3")));
            this.a4 = ((System.Windows.Controls.Image)(this.FindName("a4")));
            this.a5 = ((System.Windows.Controls.Image)(this.FindName("a5")));
            this.ok = ((System.Windows.Controls.TextBlock)(this.FindName("ok")));
            this.griglia = ((System.Windows.Controls.Grid)(this.FindName("griglia")));
            this.firstAd = ((Microsoft.Advertising.Mobile.UI.AdControl)(this.FindName("firstAd")));
        }
    }
}

