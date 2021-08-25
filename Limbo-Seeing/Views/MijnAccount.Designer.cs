
namespace Limbo_Seeing.Views
{
    partial class MijnAccount
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NewEmail = new System.Windows.Forms.TextBox();
            this.NewName = new System.Windows.Forms.TextBox();
            this.NewLastName = new System.Windows.Forms.TextBox();
            this.NewBirthDate = new System.Windows.Forms.DateTimePicker();
            this.NewSex = new System.Windows.Forms.ComboBox();
            this.SaveNewData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account gegevens";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(171, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(120, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Voornaam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.Location = new System.Drawing.Point(102, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Achternaam";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label5.Location = new System.Drawing.Point(58, 148);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Geboorte datum";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label6.Location = new System.Drawing.Point(135, 175);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Geslacht";
            // 
            // NewEmail
            // 
            this.NewEmail.Location = new System.Drawing.Point(251, 69);
            this.NewEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewEmail.Name = "NewEmail";
            this.NewEmail.Size = new System.Drawing.Size(309, 22);
            this.NewEmail.TabIndex = 6;
            // 
            // NewName
            // 
            this.NewName.Location = new System.Drawing.Point(251, 96);
            this.NewName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewName.Name = "NewName";
            this.NewName.Size = new System.Drawing.Size(309, 22);
            this.NewName.TabIndex = 7;
            // 
            // NewLastName
            // 
            this.NewLastName.Location = new System.Drawing.Point(251, 123);
            this.NewLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewLastName.Name = "NewLastName";
            this.NewLastName.Size = new System.Drawing.Size(309, 22);
            this.NewLastName.TabIndex = 8;
            // 
            // NewBirthDate
            // 
            this.NewBirthDate.Location = new System.Drawing.Point(251, 150);
            this.NewBirthDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewBirthDate.Name = "NewBirthDate";
            this.NewBirthDate.Size = new System.Drawing.Size(308, 22);
            this.NewBirthDate.TabIndex = 9;
            // 
            // NewSex
            // 
            this.NewSex.FormattingEnabled = true;
            this.NewSex.Location = new System.Drawing.Point(251, 178);
            this.NewSex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewSex.Name = "NewSex";
            this.NewSex.Size = new System.Drawing.Size(96, 24);
            this.NewSex.TabIndex = 10;
            this.NewSex.SelectedIndexChanged += new System.EventHandler(this.NewSex_SelectedIndexChanged);
            // 
            // SaveNewData
            // 
            this.SaveNewData.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.SaveNewData.Location = new System.Drawing.Point(342, 261);
            this.SaveNewData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveNewData.Name = "SaveNewData";
            this.SaveNewData.Size = new System.Drawing.Size(219, 38);
            this.SaveNewData.TabIndex = 11;
            this.SaveNewData.Text = "Save";
            this.SaveNewData.UseVisualStyleBackColor = true;
            this.SaveNewData.Click += new System.EventHandler(this.SaveNewData_Click);
            // 
            // MijnAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 327);
            this.Controls.Add(this.SaveNewData);
            this.Controls.Add(this.NewSex);
            this.Controls.Add(this.NewBirthDate);
            this.Controls.Add(this.NewLastName);
            this.Controls.Add(this.NewName);
            this.Controls.Add(this.NewEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MijnAccount";
            this.Text = "tab";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NewEmail;
        private System.Windows.Forms.TextBox NewName;
        private System.Windows.Forms.TextBox NewLastName;
        private System.Windows.Forms.DateTimePicker NewBirthDate;
        private System.Windows.Forms.ComboBox NewSex;
        private System.Windows.Forms.Button SaveNewData;
    }
}