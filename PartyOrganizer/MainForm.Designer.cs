//Moa Söderberg 
//2023-11-3

namespace PartyOrganizer
{
    partial class MainForm
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
            this.grpNewParty = new System.Windows.Forms.GroupBox();
            this.btnCreateList = new System.Windows.Forms.Button();
            this.txtFeePerPerson = new System.Windows.Forms.TextBox();
            this.txtCostPerPerson = new System.Windows.Forms.TextBox();
            this.txtMaxNumOfGuests = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpInviteGuest = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblNumOfGuests = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.lblSurplusDeficit = new System.Windows.Forms.Label();
            this.lstGuests = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpNewParty.SuspendLayout();
            this.grpInviteGuest.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNewParty
            // 
            this.grpNewParty.Controls.Add(this.btnCreateList);
            this.grpNewParty.Controls.Add(this.txtFeePerPerson);
            this.grpNewParty.Controls.Add(this.txtCostPerPerson);
            this.grpNewParty.Controls.Add(this.txtMaxNumOfGuests);
            this.grpNewParty.Controls.Add(this.label3);
            this.grpNewParty.Controls.Add(this.label2);
            this.grpNewParty.Controls.Add(this.label1);
            this.grpNewParty.ForeColor = System.Drawing.Color.Teal;
            this.grpNewParty.Location = new System.Drawing.Point(27, 30);
            this.grpNewParty.Margin = new System.Windows.Forms.Padding(4);
            this.grpNewParty.Name = "grpNewParty";
            this.grpNewParty.Padding = new System.Windows.Forms.Padding(4);
            this.grpNewParty.Size = new System.Drawing.Size(305, 166);
            this.grpNewParty.TabIndex = 0;
            this.grpNewParty.TabStop = false;
            this.grpNewParty.Text = "New Party";
            // 
            // btnCreateList
            // 
            this.btnCreateList.Location = new System.Drawing.Point(94, 123);
            this.btnCreateList.Name = "btnCreateList";
            this.btnCreateList.Size = new System.Drawing.Size(111, 31);
            this.btnCreateList.TabIndex = 6;
            this.btnCreateList.Text = "Create List";
            this.btnCreateList.UseVisualStyleBackColor = true;
            this.btnCreateList.Click += new System.EventHandler(this.btnCreateList_Click);
            // 
            // txtFeePerPerson
            // 
            this.txtFeePerPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFeePerPerson.Location = new System.Drawing.Point(188, 85);
            this.txtFeePerPerson.Name = "txtFeePerPerson";
            this.txtFeePerPerson.Size = new System.Drawing.Size(100, 22);
            this.txtFeePerPerson.TabIndex = 5;
            // 
            // txtCostPerPerson
            // 
            this.txtCostPerPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCostPerPerson.Location = new System.Drawing.Point(188, 57);
            this.txtCostPerPerson.Name = "txtCostPerPerson";
            this.txtCostPerPerson.Size = new System.Drawing.Size(100, 22);
            this.txtCostPerPerson.TabIndex = 4;
            // 
            // txtMaxNumOfGuests
            // 
            this.txtMaxNumOfGuests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaxNumOfGuests.Location = new System.Drawing.Point(188, 30);
            this.txtMaxNumOfGuests.Name = "txtMaxNumOfGuests";
            this.txtMaxNumOfGuests.Size = new System.Drawing.Size(100, 22);
            this.txtMaxNumOfGuests.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fee per person";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cost per person";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Max number of guests";
            // 
            // grpInviteGuest
            // 
            this.grpInviteGuest.Controls.Add(this.btnAdd);
            this.grpInviteGuest.Controls.Add(this.txtLastName);
            this.grpInviteGuest.Controls.Add(this.txtFirstName);
            this.grpInviteGuest.Controls.Add(this.label5);
            this.grpInviteGuest.Controls.Add(this.label4);
            this.grpInviteGuest.ForeColor = System.Drawing.Color.Teal;
            this.grpInviteGuest.Location = new System.Drawing.Point(27, 215);
            this.grpInviteGuest.Name = "grpInviteGuest";
            this.grpInviteGuest.Size = new System.Drawing.Size(305, 148);
            this.grpInviteGuest.TabIndex = 1;
            this.grpInviteGuest.TabStop = false;
            this.grpInviteGuest.Text = "Invite Guest";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(94, 103);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 31);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Location = new System.Drawing.Point(109, 62);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(179, 22);
            this.txtLastName.TabIndex = 3;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Location = new System.Drawing.Point(109, 33);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(179, 22);
            this.txtFirstName.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(12, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(12, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "First Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Number of Guests";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Total Cost";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 459);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Total Fees";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 491);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Surplus/deficit";
            // 
            // lblNumOfGuests
            // 
            this.lblNumOfGuests.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumOfGuests.Location = new System.Drawing.Point(218, 390);
            this.lblNumOfGuests.Name = "lblNumOfGuests";
            this.lblNumOfGuests.Size = new System.Drawing.Size(109, 26);
            this.lblNumOfGuests.TabIndex = 6;
            this.lblNumOfGuests.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCost.Location = new System.Drawing.Point(218, 421);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(109, 26);
            this.lblTotalCost.TabIndex = 7;
            this.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalFees.Location = new System.Drawing.Point(218, 454);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(109, 26);
            this.lblTotalFees.TabIndex = 8;
            this.lblTotalFees.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSurplusDeficit
            // 
            this.lblSurplusDeficit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSurplusDeficit.Location = new System.Drawing.Point(218, 486);
            this.lblSurplusDeficit.Name = "lblSurplusDeficit";
            this.lblSurplusDeficit.Size = new System.Drawing.Size(109, 26);
            this.lblSurplusDeficit.TabIndex = 9;
            this.lblSurplusDeficit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lstGuests
            // 
            this.lstGuests.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstGuests.FormattingEnabled = true;
            this.lstGuests.ItemHeight = 16;
            this.lstGuests.Location = new System.Drawing.Point(373, 60);
            this.lstGuests.Name = "lstGuests";
            this.lstGuests.Size = new System.Drawing.Size(266, 372);
            this.lstGuests.TabIndex = 10;
            this.lstGuests.SelectedIndexChanged += new System.EventHandler(this.lstGuests_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Teal;
            this.label10.Location = new System.Drawing.Point(465, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Guest List";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(373, 456);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(111, 31);
            this.btnChange.TabIndex = 12;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Firebrick;
            this.btnDelete.Location = new System.Drawing.Point(528, 456);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 31);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 554);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lstGuests);
            this.Controls.Add(this.lblSurplusDeficit);
            this.Controls.Add(this.lblTotalFees);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblNumOfGuests);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grpInviteGuest);
            this.Controls.Add(this.grpNewParty);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Party Organizer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpNewParty.ResumeLayout(false);
            this.grpNewParty.PerformLayout();
            this.grpInviteGuest.ResumeLayout(false);
            this.grpInviteGuest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNewParty;
        private System.Windows.Forms.TextBox txtFeePerPerson;
        private System.Windows.Forms.TextBox txtCostPerPerson;
        private System.Windows.Forms.TextBox txtMaxNumOfGuests;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateList;
        private System.Windows.Forms.GroupBox grpInviteGuest;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblNumOfGuests;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label lblSurplusDeficit;
        private System.Windows.Forms.ListBox lstGuests;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
    }
}

