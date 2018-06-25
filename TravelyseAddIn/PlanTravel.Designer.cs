using System;
using System.Windows.Forms;

namespace TravelyseAddInNM
{
    partial class ucPlanTravel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlanTravel = new System.Windows.Forms.Button();
            this.dgvTravelPlan = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlConfirmBooking = new System.Windows.Forms.Panel();
            this.dgvItinerary = new System.Windows.Forms.DataGridView();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTravelPlan)).BeginInit();
            this.pnlConfirmBooking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItinerary)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Upcoming Travel ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnPlanTravel
            // 
            this.btnPlanTravel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPlanTravel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanTravel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnPlanTravel.Location = new System.Drawing.Point(257, 14);
            this.btnPlanTravel.Name = "btnPlanTravel";
            this.btnPlanTravel.Size = new System.Drawing.Size(122, 33);
            this.btnPlanTravel.TabIndex = 4;
            this.btnPlanTravel.Text = "Plan Travel";
            this.btnPlanTravel.UseVisualStyleBackColor = false;
            this.btnPlanTravel.Click += new System.EventHandler(this.btnPlanTravel_Click);
            // 
            // dgvTravelPlan
            // 
            this.dgvTravelPlan.AllowUserToAddRows = false;
            this.dgvTravelPlan.AllowUserToDeleteRows = false;
            this.dgvTravelPlan.BackgroundColor = System.Drawing.Color.White;
            this.dgvTravelPlan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTravelPlan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTravelPlan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTravelPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTravelPlan.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTravelPlan.EnableHeadersVisualStyles = false;
            this.dgvTravelPlan.GridColor = System.Drawing.Color.White;
            this.dgvTravelPlan.Location = new System.Drawing.Point(11, 66);
            this.dgvTravelPlan.MultiSelect = false;
            this.dgvTravelPlan.Name = "dgvTravelPlan";
            this.dgvTravelPlan.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTravelPlan.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTravelPlan.RowHeadersVisible = false;
            this.dgvTravelPlan.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvTravelPlan.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.dgvTravelPlan.RowTemplate.Height = 28;
            this.dgvTravelPlan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTravelPlan.Size = new System.Drawing.Size(474, 248);
            this.dgvTravelPlan.TabIndex = 6;
            this.dgvTravelPlan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvTravelPlan.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dgvTravelPlan.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(4, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 62);
            this.label2.TabIndex = 7;
            this.label2.Text = "Congratulations on qualifying for one-click buy!";
            // 
            // pnlConfirmBooking
            // 
            this.pnlConfirmBooking.Controls.Add(this.dgvItinerary);
            this.pnlConfirmBooking.Controls.Add(this.btnConfirm);
            this.pnlConfirmBooking.Controls.Add(this.btnCancel);
            this.pnlConfirmBooking.Controls.Add(this.label3);
            this.pnlConfirmBooking.Controls.Add(this.label2);
            this.pnlConfirmBooking.Location = new System.Drawing.Point(16, 320);
            this.pnlConfirmBooking.Name = "pnlConfirmBooking";
            this.pnlConfirmBooking.Size = new System.Drawing.Size(469, 508);
            this.pnlConfirmBooking.TabIndex = 11;
            this.pnlConfirmBooking.Visible = false;
            // 
            // dgvItinerary
            // 
            this.dgvItinerary.AllowUserToAddRows = false;
            this.dgvItinerary.AllowUserToDeleteRows = false;
            this.dgvItinerary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvItinerary.BackgroundColor = System.Drawing.Color.White;
            this.dgvItinerary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvItinerary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItinerary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvItinerary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItinerary.ColumnHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItinerary.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvItinerary.EnableHeadersVisualStyles = false;
            this.dgvItinerary.GridColor = System.Drawing.Color.White;
            this.dgvItinerary.Location = new System.Drawing.Point(51, 151);
            this.dgvItinerary.Name = "dgvItinerary";
            this.dgvItinerary.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItinerary.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvItinerary.RowHeadersVisible = false;
            this.dgvItinerary.RowTemplate.Height = 28;
            this.dgvItinerary.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvItinerary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItinerary.Size = new System.Drawing.Size(223, 275);
            this.dgvItinerary.TabIndex = 12;
            this.dgvItinerary.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvItinerary_CellFormatting);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfirm.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnConfirm.Location = new System.Drawing.Point(35, 440);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(122, 33);
            this.btnConfirm.TabIndex = 12;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnCancel.Location = new System.Drawing.Point(163, 440);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 33);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(5, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(382, 75);
            this.label3.TabIndex = 12;
            // 
            // ucPlanTravel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlConfirmBooking);
            this.Controls.Add(this.dgvTravelPlan);
            this.Controls.Add(this.btnPlanTravel);
            this.Controls.Add(this.label1);
            this.Name = "ucPlanTravel";
            this.Size = new System.Drawing.Size(618, 872);
            this.Load += new System.EventHandler(this.ucPlanTravel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTravelPlan)).EndInit();
            this.pnlConfirmBooking.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItinerary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlanTravel;
        private System.Windows.Forms.DataGridView dgvTravelPlan;
        private Label label2;
        private Panel pnlConfirmBooking;
        private Label label3;
        private Button btnCancel;
        private Button btnConfirm;
        private DataGridView dgvItinerary;
    }
}
