
namespace Limbo_Seeing.Views
{
    partial class MijnReseveringen
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
            this.Reseveringen_dataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activiteit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start_Tijd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eind_Tijd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QRcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Verwijder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Reseveringen_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Reseveringen_dataGridView
            // 
            this.Reseveringen_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Reseveringen_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Activiteit,
            this.Adress,
            this.Start_Tijd,
            this.Eind_Tijd,
            this.QRcode,
            this.Verwijder});
            this.Reseveringen_dataGridView.Location = new System.Drawing.Point(12, 12);
            this.Reseveringen_dataGridView.Name = "Reseveringen_dataGridView";
            this.Reseveringen_dataGridView.RowHeadersWidth = 51;
            this.Reseveringen_dataGridView.RowTemplate.Height = 24;
            this.Reseveringen_dataGridView.Size = new System.Drawing.Size(776, 349);
            this.Reseveringen_dataGridView.TabIndex = 0;
            this.Reseveringen_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Reseveringen_dataGridView_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // Activiteit
            // 
            this.Activiteit.HeaderText = "Activiteit";
            this.Activiteit.MinimumWidth = 6;
            this.Activiteit.Name = "Activiteit";
            this.Activiteit.ReadOnly = true;
            this.Activiteit.Width = 125;
            // 
            // Adress
            // 
            this.Adress.HeaderText = "Adress";
            this.Adress.MinimumWidth = 6;
            this.Adress.Name = "Adress";
            this.Adress.ReadOnly = true;
            this.Adress.Width = 125;
            // 
            // Start_Tijd
            // 
            this.Start_Tijd.HeaderText = "Start Tijd";
            this.Start_Tijd.MinimumWidth = 6;
            this.Start_Tijd.Name = "Start_Tijd";
            this.Start_Tijd.ReadOnly = true;
            this.Start_Tijd.Width = 125;
            // 
            // Eind_Tijd
            // 
            this.Eind_Tijd.HeaderText = "Eind Tijd";
            this.Eind_Tijd.MinimumWidth = 6;
            this.Eind_Tijd.Name = "Eind_Tijd";
            this.Eind_Tijd.ReadOnly = true;
            this.Eind_Tijd.Width = 125;
            // 
            // QRcode
            // 
            this.QRcode.HeaderText = "QRcode";
            this.QRcode.MinimumWidth = 6;
            this.QRcode.Name = "QRcode";
            this.QRcode.Width = 125;
            // 
            // Verwijder
            // 
            this.Verwijder.HeaderText = "Verwijder Resevering";
            this.Verwijder.MinimumWidth = 6;
            this.Verwijder.Name = "Verwijder";
            this.Verwijder.ReadOnly = true;
            this.Verwijder.Width = 125;
            // 
            // MijnReseveringen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 375);
            this.Controls.Add(this.Reseveringen_dataGridView);
            this.Name = "MijnReseveringen";
            this.Text = "MijnReseveringen";
            this.Load += new System.EventHandler(this.MijnReseveringen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Reseveringen_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Reseveringen_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activiteit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start_Tijd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eind_Tijd;
        private System.Windows.Forms.DataGridViewTextBoxColumn QRcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Verwijder;
    }
}