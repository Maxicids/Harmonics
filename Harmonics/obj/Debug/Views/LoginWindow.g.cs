#pragma checksum "..\..\..\Views\LoginWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "088AE1B9F88C48B45D41CE21D6C65342A7DAF529F38F97A22E718BF8150DEEE5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace Harmonics.Views {
    
    
    /// <summary>
    /// LoginWindow
    /// </summary>
    public partial class LoginWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\Views\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MainGrid;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Views\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid TopGrid;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Views\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MinimizeButton;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Views\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MaximizeButton;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Views\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.PackIcon ResizeIcon;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Views\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseButton;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Views\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid CentralGrid;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Views\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border MainBorder;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Views\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbLogin;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Views\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox TbPassword;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Views\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border LoginBorder;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Views\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label infoLabel;
        
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
            System.Uri resourceLocater = new System.Uri("/Harmonics;component/views/loginwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\LoginWindow.xaml"
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
            this.MainGrid = ((System.Windows.Controls.Grid)(target));
            
            #line 14 "..\..\..\Views\LoginWindow.xaml"
            this.MainGrid.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.MainGrid_OnMouseDown);
            
            #line default
            #line hidden
            
            #line 14 "..\..\..\Views\LoginWindow.xaml"
            this.MainGrid.SizeChanged += new System.Windows.SizeChangedEventHandler(this.MainGrid_OnSizeChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TopGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.MinimizeButton = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\Views\LoginWindow.xaml"
            this.MinimizeButton.Click += new System.Windows.RoutedEventHandler(this.MinimizeButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MaximizeButton = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\Views\LoginWindow.xaml"
            this.MaximizeButton.Click += new System.Windows.RoutedEventHandler(this.MaximizeButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ResizeIcon = ((MaterialDesignThemes.Wpf.PackIcon)(target));
            return;
            case 6:
            this.CloseButton = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\Views\LoginWindow.xaml"
            this.CloseButton.Click += new System.Windows.RoutedEventHandler(this.CloseButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.CentralGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 8:
            this.MainBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 9:
            this.TbLogin = ((System.Windows.Controls.TextBox)(target));
            
            #line 36 "..\..\..\Views\LoginWindow.xaml"
            this.TbLogin.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TbLogin_OnPreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 10:
            this.TbPassword = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 38 "..\..\..\Views\LoginWindow.xaml"
            this.TbPassword.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TbPassword_OnPreviewTextInput);
            
            #line default
            #line hidden
            
            #line 38 "..\..\..\Views\LoginWindow.xaml"
            this.TbPassword.PasswordChanged += new System.Windows.RoutedEventHandler(this.TbPassword_OnPasswordChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 40 "..\..\..\Views\LoginWindow.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ToRegistration_OnMouseDown);
            
            #line default
            #line hidden
            return;
            case 12:
            this.LoginBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 13:
            
            #line 44 "..\..\..\Views\LoginWindow.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Login_OnMouseDown);
            
            #line default
            #line hidden
            return;
            case 14:
            this.infoLabel = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

