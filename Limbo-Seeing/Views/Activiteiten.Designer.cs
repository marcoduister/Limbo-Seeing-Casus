
namespace Limbo_Seeing.Views
{
    partial class Activiteiten
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
            this.ActiviteitenDataView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tijd_Slots = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start_tijd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eind_tijd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reseveren = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_beheer = new System.Windows.Forms.Button();
            this.beheerlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ActiviteitenDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // ActiviteitenDataView
            // 
            this.ActiviteitenDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActiviteitenDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Naam,
            this.Adress,
            this.Tijd_Slots,
            this.Start_tijd,
            this.Eind_tijd,
            this.Reseveren});
            this.ActiviteitenDataView.Location = new System.Drawing.Point(16, 58);
            this.ActiviteitenDataView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ActiviteitenDataView.Name = "ActiviteitenDataView";
            this.ActiviteitenDataView.ReadOnly = true;
            this.ActiviteitenDataView.RowHeadersWidth = 51;
            this.ActiviteitenDataView.RowTemplate.Height = 24;
            this.ActiviteitenDataView.Size = new System.Drawing.Size(1203, 481);
            this.ActiviteitenDataView.TabIndex = 1;
            this.ActiviteitenDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ActiviteitenDataView_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Naam
            // 
            this.Naam.HeaderText = "Naam";
            this.Naam.MinimumWidth = 6;
            this.Naam.Name = "Naam";
            this.Naam.ReadOnly = true;
            this.Naam.Width = 125;
            // 
            // Adress
            // 
            this.Adress.HeaderText = "Adress";
            this.Adress.MinimumWidth = 6;
            this.Adress.Name = "Adress";
            this.Adress.ReadOnly = true;
            this.Adress.Width = 125;
            // 
            // Tijd_Slots
            // 
            this.Tijd_Slots.HeaderText = "Tijd Slots";
            this.Tijd_Slots.MinimumWidth = 6;
            this.Tijd_Slots.Name = "Tijd_Slots";
            this.Tijd_Slots.ReadOnly = true;
            this.Tijd_Slots.Width = 125;
            // 
            // Start_tijd
            // 
            this.Start_tijd.HeaderText = "Start tijd";
            this.Start_tijd.MinimumWidth = 6;
            this.Start_tijd.Name = "Start_tijd";
            this.Start_tijd.ReadOnly = true;
            this.Start_tijd.Width = 125;
            // 
            // Eind_tijd
            // 
            this.Eind_tijd.HeaderText = "Eind tijd";
            this.Eind_tijd.MinimumWidth = 6;
            this.Eind_tijd.Name = "Eind_tijd";
            this.Eind_tijd.ReadOnly = true;
            this.Eind_tijd.Width = 125;
            // 
            // Reseveren
            // 
            this.Reseveren.HeaderText = "Reseveren";
            this.Reseveren.MinimumWidth = 6;
            this.Reseveren.Name = "Reseveren";
            this.Reseveren.ReadOnly = true;
            this.Reseveren.Width = 125;
            // 
            // btn_beheer
            // 
            this.btn_beheer.Location = new System.Drawing.Point(206, 13);
            this.btn_beheer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_beheer.Name = "btn_beheer";
            this.btn_beheer.Size = new System.Drawing.Size(145, 36);
            this.btn_beheer.TabIndex = 2;
            this.btn_beheer.Text = "Beheer";
            this.btn_beheer.UseVisualStyleBackColor = true;
            this.btn_beheer.Click += new System.EventHandler(this.btn_beheer_Click);
            // 
            // beheerlabel
            // 
            this.beheerlabel.AutoSize = true;
            this.beheerlabel.Location = new System.Drawing.Point(16, 22);
            this.beheerlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.beheerlabel.Name = "beheerlabel";
            this.beheerlabel.Size = new System.Drawing.Size(163, 17);
            this.beheerlabel.TabIndex = 3;
            this.beheerlabel.Text = "Mijn Activiteiten Beheren";
            // 
            // Activiteiten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 554);
            this.Controls.Add(this.beheerlabel);
            this.Controls.Add(this.btn_beheer);
            this.Controls.Add(this.ActiviteitenDataView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Activiteiten";
            this.Text = "Activiteiten";
            this.Load += new System.EventHandler(this.Activiteiten_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ActiviteitenDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ActiviteitenDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tijd_Slots;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start_tijd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eind_tijd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reseveren;
        private System.Windows.Forms.Button btn_beheer;
        private System.Windows.Forms.Label beheerlabel;
    }
}