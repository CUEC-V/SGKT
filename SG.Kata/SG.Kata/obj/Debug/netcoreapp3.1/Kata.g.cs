﻿#pragma checksum "..\..\..\Kata.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47265F78B616E89B2FF80CF4EBBD65384A037F3B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using SG.Kata;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace SG.Kata {
    
    
    /// <summary>
    /// Kata
    /// </summary>
    public partial class Kata : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\Kata.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SG.Kata.Kata KataL;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Kata.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox RecetteLab;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Kata.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PrixVente;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Kata.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label RecetteAj;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\Kata.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label IngredientAj;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.7.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SG.Kata;component/kata.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Kata.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.7.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.KataL = ((SG.Kata.Kata)(target));
            
            #line 10 "..\..\..\Kata.xaml"
            this.KataL.Loaded += new System.Windows.RoutedEventHandler(this.KTLoaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.RecetteLab = ((System.Windows.Controls.ListBox)(target));
            
            #line 39 "..\..\..\Kata.xaml"
            this.RecetteLab.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.RecetteSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.PrixVente = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.RecetteAj = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.IngredientAj = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

