﻿#pragma checksum "..\..\..\..\View\Pages\AddEdit.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5EF89B19723B4A27701F5DB5FE38E14EF21C50290867C0FC169C260F98E101E5"
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
    /// AddEdit
    /// </summary>
    public partial class AddEdit : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\..\View\Pages\AddEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LastName;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\View\Pages\AddEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Name;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\View\Pages\AddEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Patronymic;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\View\Pages\AddEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Sex;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\View\Pages\AddEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Group;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\View\Pages\AddEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel NonUpdatableFields;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\View\Pages\AddEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Mothers;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\View\Pages\AddEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Fathers;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\View\Pages\AddEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Addresses;
        
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
            System.Uri resourceLocater = new System.Uri("/DedSad;component/view/pages/addedit.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Pages\AddEdit.xaml"
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
            this.LastName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Patronymic = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Sex = ((System.Windows.Controls.CheckBox)(target));
            
            #line 21 "..\..\..\..\View\Pages\AddEdit.xaml"
            this.Sex.Checked += new System.Windows.RoutedEventHandler(this.Sex_Checked);
            
            #line default
            #line hidden
            
            #line 21 "..\..\..\..\View\Pages\AddEdit.xaml"
            this.Sex.Unchecked += new System.Windows.RoutedEventHandler(this.Sex_Unchecked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Group = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.NonUpdatableFields = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 7:
            this.Mothers = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.Fathers = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.Addresses = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            
            #line 36 "..\..\..\..\View\Pages\AddEdit.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Save_Button_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 37 "..\..\..\..\View\Pages\AddEdit.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Back_Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

