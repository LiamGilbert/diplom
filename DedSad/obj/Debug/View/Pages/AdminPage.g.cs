﻿#pragma checksum "..\..\..\..\View\Pages\AdminPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AB28378A56AE13F8C028F12D9C877496E106746DD78CD0F5053E6351A77837E1"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using DedSad.View.Pages;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace DedSad.View.Pages {
    
    
    /// <summary>
    /// AdminPage
    /// </summary>
    public partial class AdminPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 18 "..\..\..\..\View\Pages\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ListViewChildren;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\View\Pages\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchTB;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\View\Pages\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox GroupCB;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\View\Pages\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddButton;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\View\Pages\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DdeleteButton;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\View\Pages\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RedButton;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\View\Pages\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExcelButton;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\View\Pages\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GroupBt;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\View\Pages\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EducBt;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/DedSad;component/view/pages/adminpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Pages\AdminPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ListViewChildren = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.SearchTB = ((System.Windows.Controls.TextBox)(target));
            
            #line 37 "..\..\..\..\View\Pages\AdminPage.xaml"
            this.SearchTB.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchTB_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.GroupCB = ((System.Windows.Controls.ComboBox)(target));
            
            #line 39 "..\..\..\..\View\Pages\AdminPage.xaml"
            this.GroupCB.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.GroupCB_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.AddButton = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\..\View\Pages\AdminPage.xaml"
            this.AddButton.Click += new System.Windows.RoutedEventHandler(this.AddButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.DdeleteButton = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\..\View\Pages\AdminPage.xaml"
            this.DdeleteButton.Click += new System.Windows.RoutedEventHandler(this.DdeleteButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.RedButton = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\..\View\Pages\AdminPage.xaml"
            this.RedButton.Click += new System.Windows.RoutedEventHandler(this.RedButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ExcelButton = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\..\View\Pages\AdminPage.xaml"
            this.ExcelButton.Click += new System.Windows.RoutedEventHandler(this.ExcelButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 44 "..\..\..\..\View\Pages\AdminPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.GroupBt = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\..\View\Pages\AdminPage.xaml"
            this.GroupBt.Click += new System.Windows.RoutedEventHandler(this.NavigateToGroupPage);
            
            #line default
            #line hidden
            return;
            case 11:
            this.EducBt = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\..\View\Pages\AdminPage.xaml"
            this.EducBt.Click += new System.Windows.RoutedEventHandler(this.NavigateToEducatorsPage);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 2:
            
            #line 28 "..\..\..\..\View\Pages\AdminPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.NavigateToMoreInformation);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

