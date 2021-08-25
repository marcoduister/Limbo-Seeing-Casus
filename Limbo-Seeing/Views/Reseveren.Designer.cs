
namespace Limbo_Seeing.Views
{
    partial class Reseveren
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
            this.CBox_tijdslots = new System.Windows.Forms.ComboBox();
            this.Activteit_label = new System.Windows.Forms.Label();
            this.Tijdslot_label = new System.Windows.Forms.Label();
            this.btn_reseveren = new System.Windows.Forms.Button();
            this.btn_terug = new System.Windows.Forms.Button();
            this.activteit_actie_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CBox_tijdslots
            // 
            this.CBox_tijdslots.FormattingEnabled = true;
            this.CBox_tijdslots.Location = new System.Drawing.Point(185, 82);
            this.CBox_tijdslots.Name = "CBox_tijdslots";
            this.CBox_tijdslots.Size = new System.Drawing.Size(188, 24);
            this.CBox_tijdslots.TabIndex = 0;
            // 
            // Activteit_label
            // 
            this.Activteit_label.AutoSize = true;
            this.Activteit_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activteit_label.Location = new System.Drawing.Point(24, 38);
            this.Activteit_label.Name = "Activteit_label";
            this.Activteit_label.Size = new System.Drawing.Size(71, 17);
            this.Activteit_label.TabIndex = 1;
            this.Activteit_label.Text = "Activteit:";
            // 
            // Tijdslot_label
            // 
            this.Tijdslot_label.AutoSize = true;
            this.Tijdslot_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tijdslot_label.Location = new System.Drawing.Point(24, 85);
            this.Tijdslot_label.Name = "Tijdslot_label";
            this.Tijdslot_label.Size = new System.Drawing.Size(150, 17);
            this.Tijdslot_label.TabIndex = 2;
            this.Tijdslot_label.Text = "Tijdslot deelnamen:";
            // 
            // btn_reseveren
            // 
            this.btn_reseveren.Location = new System.Drawing.Point(274, 131);
            this.btn_reseveren.Name = "btn_reseveren";
            this.btn_reseveren.Size = new System.Drawing.Size(99, 39);
            this.btn_reseveren.TabIndex = 5;
            this.btn_reseveren.Text = "Reseveren";
            this.btn_reseveren.UseVisualStyleBackColor = true;
            this.btn_reseveren.Click += new System.EventHandler(this.btn_reseveren_Click);
            // 
            // btn_terug
            // 
            this.btn_terug.Location = new System.Drawing.Point(169, 131);
            this.btn_terug.Name = "btn_terug";
            this.btn_terug.Size = new System.Drawing.Size(99, 39);
            this.btn_terug.TabIndex = 6;
            this.btn_terug.Text = "Terug";
            this.btn_terug.UseVisualStyleBackColor = true;
            this.btn_terug.Click += new System.EventHandler(this.btn_terug_Click);
            // 
            // activteit_actie_label
            // 
            this.activteit_actie_label.AutoSize = true;
            this.activteit_actie_label.Location = new System.Drawing.Point(182, 38);
            this.activteit_actie_label.Name = "activteit_actie_label";
            this.activteit_actie_label.Size = new System.Drawing.Size(38, 17);
            this.activteit_actie_label.TabIndex = 7;
            this.activteit_actie_label.Text = "label";
            // 
            // Reseveren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 185);
            this.Controls.Add(this.activteit_actie_label);
            this.Controls.Add(this.btn_terug);
            this.Controls.Add(this.btn_reseveren);
            this.Controls.Add(this.Tijdslot_label);
            this.Controls.Add(this.Activteit_label);
            this.Controls.Add(this.CBox_tijdslots);
            this.Name = "Reseveren";
            this.Text = "Reseveren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBox_tijdslots;
        private System.Windows.Forms.Label Activteit_label;
        private System.Windows.Forms.Label Tijdslot_label;
        private System.Windows.Forms.Button btn_reseveren;
        private System.Windows.Forms.Button btn_terug;
        private System.Windows.Forms.Label activteit_actie_label;
    }
}