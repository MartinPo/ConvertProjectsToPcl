// Copyright (c) 2013 Pavel Samokha
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using MLabs.ConvertToPcl.DataContracts;
using MLabs.ConvertToPcl.ViewModel;

namespace MLabs.ConvertToPcl
{
    public partial class ProjectsUpdateList : Form
    {
        public event Action UpdateFired;
        public event Action ReloadFired;

        public ProjectsUpdateList()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            cmbFrameworksinUse.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPortables.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public List<NetFramework> FrameworksInUse { set { cmbFrameworksinUse.DataSource = value; } }

        public List<PortableFramework> PossiblePortableFrameworks { set { cmbPortables.DataSource = value; } }
        public List<ProjectModel> Projects
        {
            set
            {
                var wrapperBindingList = new SortableBindingList<ProjectModel>(value);
                dataGridView1.DataSource = wrapperBindingList;
                dataGridView1.Refresh();
            }
            get
            {
                var wrapperBindingList = (SortableBindingList<ProjectModel>)dataGridView1.DataSource;
                return wrapperBindingList.WrappedList;
            }
        }

        public PortableFramework SelectedPortableFramework
        {
            get { return (PortableFramework) cmbPortables.SelectedItem; }
        }

        public string State { set { label1.Text = value; } }

        private async void button3_Click(object sender, EventArgs e)
        {
            var onUpdate = UpdateFired;
            if(onUpdate != null)
                onUpdate.Invoke();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var projectModel in Projects)
            {
                projectModel.IsSelected = true;
            }
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var projectModel in Projects)
            {
                projectModel.IsSelected = false;
            }
            dataGridView1.Refresh();
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            var onReloadFired = ReloadFired;
            if(onReloadFired != null)
                onReloadFired.Invoke();
        }
    }
}
