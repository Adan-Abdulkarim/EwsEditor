﻿namespace EWSEditor.Forms
{
    partial class DistributionListExpansionForm
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
            if (disposing && (components != null))
            {
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtListSmtp = new System.Windows.Forms.TextBox();
            this.btnExpand = new System.Windows.Forms.Button();
            this.tvDistributionLists = new System.Windows.Forms.TreeView();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.lvItems = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRoutingType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.txtUniqueId = new System.Windows.Forms.TextBox();
            this.btnUniqueIdExpand = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distribution List address or name:";
            // 
            // txtListSmtp
            // 
            this.txtListSmtp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtListSmtp.Location = new System.Drawing.Point(180, 11);
            this.txtListSmtp.Name = "txtListSmtp";
            this.txtListSmtp.Size = new System.Drawing.Size(550, 20);
            this.txtListSmtp.TabIndex = 1;
            // 
            // btnExpand
            // 
            this.btnExpand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExpand.Location = new System.Drawing.Point(736, 9);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(72, 23);
            this.btnExpand.TabIndex = 2;
            this.btnExpand.Text = "Expand";
            this.btnExpand.UseVisualStyleBackColor = true;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // tvDistributionLists
            // 
            this.tvDistributionLists.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvDistributionLists.Location = new System.Drawing.Point(12, 62);
            this.tvDistributionLists.Name = "tvDistributionLists";
            this.tvDistributionLists.Size = new System.Drawing.Size(796, 185);
            this.tvDistributionLists.TabIndex = 3;
            this.tvDistributionLists.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvDistributionLists_BeforeExpand);
            this.tvDistributionLists.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDistributionLists_AfterSelect);
            // 
            // lvItems
            // 
            this.lvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colAddress,
            this.colType,
            this.colRoutingType,
            this.colId});
            this.lvItems.FullRowSelect = true;
            this.lvItems.HideSelection = false;
            this.lvItems.Location = new System.Drawing.Point(12, 253);
            this.lvItems.MultiSelect = false;
            this.lvItems.Name = "lvItems";
            this.lvItems.ShowItemToolTips = true;
            this.lvItems.Size = new System.Drawing.Size(796, 272);
            this.lvItems.TabIndex = 4;
            this.lvItems.UseCompatibleStateImageBehavior = false;
            this.lvItems.View = System.Windows.Forms.View.Details;
            this.lvItems.SelectedIndexChanged += new System.EventHandler(this.lstEvents_SelectedIndexChanged);
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 200;
            // 
            // colAddress
            // 
            this.colAddress.Text = "Address";
            this.colAddress.Width = 200;
            // 
            // colType
            // 
            this.colType.Text = "Mailbox Type";
            this.colType.Width = 150;
            // 
            // colRoutingType
            // 
            this.colRoutingType.Text = "Routing Type";
            this.colRoutingType.Width = 150;
            // 
            // colId
            // 
            this.colId.Text = "ID";
            this.colId.Width = 400;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contact Group UniqueId:";
            // 
            // txtUniqueId
            // 
            this.txtUniqueId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUniqueId.Location = new System.Drawing.Point(180, 37);
            this.txtUniqueId.Name = "txtUniqueId";
            this.txtUniqueId.Size = new System.Drawing.Size(550, 20);
            this.txtUniqueId.TabIndex = 6;
            // 
            // btnUniqueIdExpand
            // 
            this.btnUniqueIdExpand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUniqueIdExpand.Location = new System.Drawing.Point(736, 34);
            this.btnUniqueIdExpand.Name = "btnUniqueIdExpand";
            this.btnUniqueIdExpand.Size = new System.Drawing.Size(72, 23);
            this.btnUniqueIdExpand.TabIndex = 7;
            this.btnUniqueIdExpand.Text = "Expand";
            this.btnUniqueIdExpand.UseVisualStyleBackColor = true;
            this.btnUniqueIdExpand.Click += new System.EventHandler(this.btnUniqueIdExpand_Click);
            // 
            // DistributionListExpansionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 538);
            this.Controls.Add(this.btnUniqueIdExpand);
            this.Controls.Add(this.txtUniqueId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvItems);
            this.Controls.Add(this.tvDistributionLists);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtListSmtp);
            this.Controls.Add(this.btnExpand);
            this.Name = "DistributionListExpansionForm";
            this.Text = "Distribution List Expansion";
            this.Load += new System.EventHandler(this.DistributionListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtListSmtp;
        private System.Windows.Forms.Button btnExpand;
        private System.Windows.Forms.TreeView tvDistributionLists;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ListView lvItems;
        private System.Windows.Forms.ColumnHeader colAddress;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colRoutingType;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUniqueId;
        private System.Windows.Forms.Button btnUniqueIdExpand;
    }
}