// Updated by XamlIntelliSenseFileGenerator 11.12.2024 17:07:50
#pragma checksum "..\..\..\..\Pages\Nurse\NursePatients.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CC1005337ACC29341B8E76EA3BAEA085168965FFE9D4AFCBAC698389B388A010"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using Информационная_система_для_больницы.Pages.Nurse;


namespace Информационная_система_для_больницы.Pages.Nurse
{


    /// <summary>
    /// NursePatients
    /// </summary>
    public partial class NursePatients : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector
    {


#line 13 "..\..\..\..\Pages\Nurse\NursePatients.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid nursePatientsMainPart;

#line default
#line hidden


#line 29 "..\..\..\..\Pages\Nurse\NursePatients.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label nursePatientsCurrentPatientsAmount;

#line default
#line hidden


#line 41 "..\..\..\..\Pages\Nurse\NursePatients.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox nursePatientsSearchPatient;

#line default
#line hidden


#line 43 "..\..\..\..\Pages\Nurse\NursePatients.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox nursePatientsSearchWard;

#line default
#line hidden


#line 48 "..\..\..\..\Pages\Nurse\NursePatients.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border nursePatientsDataGridBorder;

#line default
#line hidden


#line 49 "..\..\..\..\Pages\Nurse\NursePatients.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid nursePatientsDataGrid;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Информационная система для больницы;component/pages/nurse/nursepatients.xaml", System.UriKind.Relative);

#line 1 "..\..\..\..\Pages\Nurse\NursePatients.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.nursePatientsMainPart = ((System.Windows.Controls.Grid)(target));

#line 13 "..\..\..\..\Pages\Nurse\NursePatients.xaml"
                    this.nursePatientsMainPart.IsEnabledChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.nursePatientsMainPart_IsEnabledChanged);

#line default
#line hidden
                    return;
                case 2:
                    this.nursePatientsCurrentPatientsAmount = ((System.Windows.Controls.Label)(target));
                    return;
                case 3:
                    this.nursePatientsSearchPatient = ((System.Windows.Controls.ComboBox)(target));
                    return;
                case 4:
                    this.nursePatientsSearchWard = ((System.Windows.Controls.ComboBox)(target));
                    return;
                case 5:
                    this.nursePatientsDataGridBorder = ((System.Windows.Controls.Border)(target));
                    return;
                case 6:
                    this.nursePatientsDataGrid = ((System.Windows.Controls.DataGrid)(target));

#line 49 "..\..\..\..\Pages\Nurse\NursePatients.xaml"
                    this.nursePatientsDataGrid.SelectedCellsChanged += new System.Windows.Controls.SelectedCellsChangedEventHandler(this.nursePatientsDataGrid_SelectedCellsChanged);

#line default
#line hidden

#line 49 "..\..\..\..\Pages\Nurse\NursePatients.xaml"
                    this.nursePatientsDataGrid.AutoGeneratedColumns += new System.EventHandler(this.nursePatientsDataGrid_AutoGeneratedColumns);

#line default
#line hidden
                    return;
                case 7:
                    this.nursePatientsListFormAlter = ((System.Windows.Controls.Button)(target));

#line 58 "..\..\..\..\Pages\Nurse\NursePatients.xaml"
                    this.nursePatientsListFormAlter.Click += new System.Windows.RoutedEventHandler(this.nursePatientsListFormAlter_Click);

#line default
#line hidden
                    return;
                case 8:
                    this.nursePatientsListFormDelete = ((System.Windows.Controls.Button)(target));

#line 59 "..\..\..\..\Pages\Nurse\NursePatients.xaml"
                    this.nursePatientsListFormDelete.Click += new System.Windows.RoutedEventHandler(this.nursePatientsListFormDelete_Click);

#line default
#line hidden
                    return;
                case 9:
                    this.nursePatientsListPatientForm = ((System.Windows.Controls.Border)(target));
                    return;
                case 10:
                    this.nursePatientsPatientListFormCancel = ((System.Windows.Controls.Button)(target));

#line 95 "..\..\..\..\Pages\Nurse\NursePatients.xaml"
                    this.nursePatientsPatientListFormCancel.Click += new System.Windows.RoutedEventHandler(this.nursePatientsPatientListFormCancel_Click);

#line default
#line hidden
                    return;
                case 11:
                    this.nursePatientsPatientForm = ((System.Windows.Controls.Border)(target));
                    return;
                case 12:
                    this.nursePatientsPatientFormPatient = ((System.Windows.Controls.ComboBox)(target));
                    return;
                case 13:
                    this.nursePatientsPatientFormReason = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 14:
                    this.nursePatientsPatientFormStart = ((System.Windows.Controls.DatePicker)(target));
                    return;
                case 15:
                    this.nursePatientsPatientFormEnd = ((System.Windows.Controls.DatePicker)(target));
                    return;
                case 16:
                    this.nursePatientsPatientFormDoctor = ((System.Windows.Controls.ComboBox)(target));
                    return;
                case 17:
                    this.nursePatientsPatientFormWard = ((System.Windows.Controls.ComboBox)(target));

#line 129 "..\..\..\..\Pages\Nurse\NursePatients.xaml"
                    this.nursePatientsPatientFormWard.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.nursePatientsPatientFormWard_SelectionChanged);

#line default
#line hidden
                    return;
                case 18:
                    this.nursePatientsPatientFormBed = ((System.Windows.Controls.ComboBox)(target));
                    return;
                case 19:
                    this.nursePatientsPatientFormAccept = ((System.Windows.Controls.Button)(target));

#line 134 "..\..\..\..\Pages\Nurse\NursePatients.xaml"
                    this.nursePatientsPatientFormAccept.Click += new System.Windows.RoutedEventHandler(this.nursePatientsPatientFormAccept_Click);

#line default
#line hidden
                    return;
                case 20:
                    this.nursePatientsPatientFormCancel = ((System.Windows.Controls.Button)(target));

#line 135 "..\..\..\..\Pages\Nurse\NursePatients.xaml"
                    this.nursePatientsPatientFormCancel.Click += new System.Windows.RoutedEventHandler(this.nursePatientsPatientFormCancel_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Button nursePatientsListShowCondition;
        internal System.Windows.Controls.Button nursePatientsListShowSchedule;
        internal System.Windows.Controls.Border nursePatientsConditionsForm;
        internal System.Windows.Controls.Label nursePatientsConditionstLabel;
        internal System.Windows.Controls.ListBox nursePatientsConditionsIndicatorsList;
        internal System.Windows.Controls.Border nursePatientsConditionsDataGridBorder;
        internal System.Windows.Controls.DataGrid nursePatientsConditionsDataGrid;
        internal System.Windows.Controls.Button nursePatientsConditionsAdd;
        internal System.Windows.Controls.Button nursePatientsConditionsAlter;
        internal System.Windows.Controls.Button nursePatientsConditionsDelete;
        internal System.Windows.Controls.Border nursePatientsSchedulesForm;
        internal System.Windows.Controls.Label nursePatientsSchedulestLabel;
        internal System.Windows.Controls.Border nursePatientsSchedulesDataGridBorder;
        internal System.Windows.Controls.DataGrid nursePatientsSchedulesDataGrid;
        internal System.Windows.Controls.Button nursePatientsConditionsFormClose;
        internal System.Windows.Controls.Border nursePatientsSchedulesAppointmentsDataGridBorder;
        internal System.Windows.Controls.DataGrid nursePatientsSchedulesAppointmentsDataGrid;
        internal System.Windows.Controls.Button nursePatientsSchedulesFormAlterStatus;
        internal System.Windows.Controls.Button nursePatientsSchedulesFormClose;
    }
}

