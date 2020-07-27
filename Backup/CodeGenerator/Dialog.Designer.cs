﻿namespace NClass.CodeGenerator
{
	partial class Dialog
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.chkUseTabs = new System.Windows.Forms.CheckBox();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.lblDestination = new System.Windows.Forms.Label();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.txtDestination = new System.Windows.Forms.TextBox();
			this.updIndentSize = new System.Windows.Forms.NumericUpDown();
			this.lblIndentSize = new System.Windows.Forms.Label();
			this.lstImportList = new System.Windows.Forms.ListBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolDelete = new System.Windows.Forms.ToolStripButton();
			this.toolMoveDown = new System.Windows.Forms.ToolStripButton();
			this.toolMoveUp = new System.Windows.Forms.ToolStripButton();
			this.toolImportList = new System.Windows.Forms.ToolStripLabel();
			this.txtNewImport = new System.Windows.Forms.TextBox();
			this.btnAddItem = new System.Windows.Forms.Button();
			this.grpCodeStyle = new System.Windows.Forms.GroupBox();
			this.txtProjectName = new System.Windows.Forms.TextBox();
			this.lblProjectName = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize) (this.updIndentSize)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.grpCodeStyle.SuspendLayout();
			this.SuspendLayout();
			// 
			// chkUseTabs
			// 
			this.chkUseTabs.AutoSize = true;
			this.chkUseTabs.Location = new System.Drawing.Point(13, 29);
			this.chkUseTabs.Name = "chkUseTabs";
			this.chkUseTabs.Size = new System.Drawing.Size(120, 17);
			this.chkUseTabs.TabIndex = 0;
			this.chkUseTabs.Text = "Use tabs for indents";
			this.chkUseTabs.UseVisualStyleBackColor = true;
			this.chkUseTabs.CheckedChanged += new System.EventHandler(this.chkUseTabs_CheckedChanged);
			// 
			// btnGenerate
			// 
			this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGenerate.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnGenerate.Location = new System.Drawing.Point(387, 241);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(75, 23);
			this.btnGenerate.TabIndex = 10;
			this.btnGenerate.Text = "Generate";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.cmdGenerate_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(468, 241);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 11;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// lblDestination
			// 
			this.lblDestination.AutoSize = true;
			this.lblDestination.Location = new System.Drawing.Point(9, 25);
			this.lblDestination.Name = "lblDestination";
			this.lblDestination.Size = new System.Drawing.Size(63, 13);
			this.lblDestination.TabIndex = 0;
			this.lblDestination.Text = "Destination:";
			// 
			// btnBrowse
			// 
			this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowse.Location = new System.Drawing.Point(468, 20);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(75, 23);
			this.btnBrowse.TabIndex = 2;
			this.btnBrowse.Text = "Browse...";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// txtDestination
			// 
			this.txtDestination.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtDestination.Location = new System.Drawing.Point(78, 22);
			this.txtDestination.Name = "txtDestination";
			this.txtDestination.Size = new System.Drawing.Size(384, 20);
			this.txtDestination.TabIndex = 1;
			// 
			// updIndentSize
			// 
			this.updIndentSize.Location = new System.Drawing.Point(13, 75);
			this.updIndentSize.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
			this.updIndentSize.Name = "updIndentSize";
			this.updIndentSize.Size = new System.Drawing.Size(82, 20);
			this.updIndentSize.TabIndex = 2;
			this.updIndentSize.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
			// 
			// lblIndentSize
			// 
			this.lblIndentSize.AutoSize = true;
			this.lblIndentSize.Enabled = false;
			this.lblIndentSize.Location = new System.Drawing.Point(10, 59);
			this.lblIndentSize.Name = "lblIndentSize";
			this.lblIndentSize.Size = new System.Drawing.Size(61, 13);
			this.lblIndentSize.TabIndex = 1;
			this.lblIndentSize.Text = "Indent size:";
			// 
			// lstImportList
			// 
			this.lstImportList.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lstImportList.FormattingEnabled = true;
			this.lstImportList.Location = new System.Drawing.Point(12, 90);
			this.lstImportList.Name = "lstImportList";
			this.lstImportList.Size = new System.Drawing.Size(269, 147);
			this.lstImportList.TabIndex = 4;
			this.lstImportList.Leave += new System.EventHandler(this.lstImportList_Leave);
			this.lstImportList.SelectedValueChanged += new System.EventHandler(this.lstImportList_SelectedValueChanged);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.toolStrip1.AutoSize = false;
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolDelete,
            this.toolMoveDown,
            this.toolMoveUp,
            this.toolImportList});
			this.toolStrip1.Location = new System.Drawing.Point(12, 62);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.toolStrip1.Size = new System.Drawing.Size(269, 25);
			this.toolStrip1.TabIndex = 3;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolDelete
			// 
			this.toolDelete.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolDelete.Enabled = false;
			this.toolDelete.Image = global::NClass.CodeGenerator.Properties.Resources.Delete;
			this.toolDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolDelete.Name = "toolDelete";
			this.toolDelete.Size = new System.Drawing.Size(23, 22);
			this.toolDelete.Text = "Delete";
			this.toolDelete.Click += new System.EventHandler(this.toolDelete_Click);
			// 
			// toolMoveDown
			// 
			this.toolMoveDown.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolMoveDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolMoveDown.Enabled = false;
			this.toolMoveDown.Image = global::NClass.CodeGenerator.Properties.Resources.MoveDown;
			this.toolMoveDown.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolMoveDown.Name = "toolMoveDown";
			this.toolMoveDown.Size = new System.Drawing.Size(23, 22);
			this.toolMoveDown.Text = "Move Down";
			this.toolMoveDown.Click += new System.EventHandler(this.toolMoveDown_Click);
			// 
			// toolMoveUp
			// 
			this.toolMoveUp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolMoveUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolMoveUp.Enabled = false;
			this.toolMoveUp.Image = global::NClass.CodeGenerator.Properties.Resources.MoveUp;
			this.toolMoveUp.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolMoveUp.Name = "toolMoveUp";
			this.toolMoveUp.Size = new System.Drawing.Size(23, 22);
			this.toolMoveUp.Text = "Move Up";
			this.toolMoveUp.Click += new System.EventHandler(this.toolMoveUp_Click);
			// 
			// toolImportList
			// 
			this.toolImportList.Name = "toolImportList";
			this.toolImportList.Size = new System.Drawing.Size(55, 22);
			this.toolImportList.Text = "Import list";
			// 
			// txtNewImport
			// 
			this.txtNewImport.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtNewImport.Location = new System.Drawing.Point(12, 243);
			this.txtNewImport.Name = "txtNewImport";
			this.txtNewImport.Size = new System.Drawing.Size(188, 20);
			this.txtNewImport.TabIndex = 5;
			this.txtNewImport.TextChanged += new System.EventHandler(this.txtNewImport_TextChanged);
			this.txtNewImport.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNewImport_KeyDown);
			// 
			// btnAddItem
			// 
			this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddItem.Enabled = false;
			this.btnAddItem.Location = new System.Drawing.Point(206, 241);
			this.btnAddItem.Name = "btnAddItem";
			this.btnAddItem.Size = new System.Drawing.Size(75, 23);
			this.btnAddItem.TabIndex = 6;
			this.btnAddItem.Text = "Add item";
			this.btnAddItem.UseVisualStyleBackColor = true;
			this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
			// 
			// grpCodeStyle
			// 
			this.grpCodeStyle.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.grpCodeStyle.Controls.Add(this.lblIndentSize);
			this.grpCodeStyle.Controls.Add(this.updIndentSize);
			this.grpCodeStyle.Controls.Add(this.chkUseTabs);
			this.grpCodeStyle.Location = new System.Drawing.Point(295, 93);
			this.grpCodeStyle.Name = "grpCodeStyle";
			this.grpCodeStyle.Size = new System.Drawing.Size(248, 142);
			this.grpCodeStyle.TabIndex = 9;
			this.grpCodeStyle.TabStop = false;
			this.grpCodeStyle.Text = "Code style";
			// 
			// txtProjectName
			// 
			this.txtProjectName.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.txtProjectName.Location = new System.Drawing.Point(372, 67);
			this.txtProjectName.Name = "txtProjectName";
			this.txtProjectName.Size = new System.Drawing.Size(171, 20);
			this.txtProjectName.TabIndex = 8;
			this.txtProjectName.Validated += new System.EventHandler(this.txtProjectName_Validated);
			// 
			// lblProjectName
			// 
			this.lblProjectName.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblProjectName.AutoSize = true;
			this.lblProjectName.Location = new System.Drawing.Point(294, 70);
			this.lblProjectName.Name = "lblProjectName";
			this.lblProjectName.Size = new System.Drawing.Size(72, 13);
			this.lblProjectName.TabIndex = 7;
			this.lblProjectName.Text = "Project name:";
			// 
			// Dialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(555, 275);
			this.Controls.Add(this.lblProjectName);
			this.Controls.Add(this.txtProjectName);
			this.Controls.Add(this.grpCodeStyle);
			this.Controls.Add(this.btnAddItem);
			this.Controls.Add(this.txtNewImport);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.lstImportList);
			this.Controls.Add(this.txtDestination);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.lblDestination);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnGenerate);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Dialog";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Code Generation";
			((System.ComponentModel.ISupportInitialize) (this.updIndentSize)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.grpCodeStyle.ResumeLayout(false);
			this.grpCodeStyle.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox chkUseTabs;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label lblDestination;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.TextBox txtDestination;
		private System.Windows.Forms.NumericUpDown updIndentSize;
		private System.Windows.Forms.Label lblIndentSize;
		private System.Windows.Forms.ListBox lstImportList;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolDelete;
		private System.Windows.Forms.ToolStripButton toolMoveDown;
		private System.Windows.Forms.ToolStripButton toolMoveUp;
		private System.Windows.Forms.ToolStripLabel toolImportList;
		private System.Windows.Forms.TextBox txtNewImport;
		private System.Windows.Forms.Button btnAddItem;
		private System.Windows.Forms.GroupBox grpCodeStyle;
		private System.Windows.Forms.TextBox txtProjectName;
		private System.Windows.Forms.Label lblProjectName;
	}
}