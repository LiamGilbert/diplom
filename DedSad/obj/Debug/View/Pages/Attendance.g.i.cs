﻿#pragma checksum "..\..\..\..\View\Pages\Attendance.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D9282E952C40C5FEF21C9FDC284783889797450DE185B37100DFEA722A477369"
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
    /// Attendance
    /// </summary>
    public partial class Attendance : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\View\Pages\Attendance.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ListViewChildren;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\View\Pages\Attendance.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox GroupCB;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\View\Pages\Attendance.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker StartDate;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\View\Pages\Attendance.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker EndDate;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\View\Pages\Attendance.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExcelButton;
        
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
            System.Uri resourceLocater = new System.Uri("/DedSad;component/view/pages/attendance.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Pages\Attendance.xaml"
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
            case 2:
            this.GroupCB = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.StartDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.EndDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.ExcelButton = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\..\View\Pages\Attendance.xaml"
            this.ExcelButton.Click += new System.Windows.RoutedEventHandler(this.ExcelButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 34 "..\..\..\..\View\Pages\Attendance.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

