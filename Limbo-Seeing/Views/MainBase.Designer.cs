
namespace Limbo_Seeing.Views
{
    partial class MainBase
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
            this.btn_uitloggen = new System.Windows.Forms.Button();
            this.btn_Account = new System.Windows.Forms.Button();
            this.btn_Activiteiten = new System.Windows.Forms.Button();
            this.btn_Mijn_Reseveringen = new System.Windows.Forms.Button();
            this.PushMelding = new System.Windows.Forms.Button();
            this.gMapControl = new GMap.NET.WindowsForms.GMapControl();
            this.label2 = new System.Windows.Forms.Label();
            this.Activteiten_datagrid = new System.Windows.Forms.DataGridView();
            this.Naam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Locatie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drukte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.AllUsers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Activteiten_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome bij Limbo-Seeing";
            // 
            // btn_uitloggen
            // 
            this.btn_uitloggen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_uitloggen.Location = new System.Drawing.Point(299, 14);
            this.btn_uitloggen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_uitloggen.Name = "btn_uitloggen";
            this.btn_uitloggen.Size = new System.Drawing.Size(117, 33);
            this.btn_uitloggen.TabIndex = 3;
            this.btn_uitloggen.Text = "Uitloggen";
            this.btn_uitloggen.UseVisualStyleBackColor = true;
            this.btn_uitloggen.Click += new System.EventHandler(this.btn_uitloggen_Click);
            // 
            // btn_Account
            // 
            this.btn_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Account.Location = new System.Drawing.Point(421, 14);
            this.btn_Account.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Account.Name = "btn_Account";
            this.btn_Account.Size = new System.Drawing.Size(117, 33);
            this.btn_Account.TabIndex = 6;
            this.btn_Account.Text = "Account";
            this.btn_Account.UseVisualStyleBackColor = true;
            this.btn_Account.Click += new System.EventHandler(this.btn_Account_Click);
            // 
            // btn_Activiteiten
            // 
            this.btn_Activiteiten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Activiteiten.Location = new System.Drawing.Point(544, 14);
            this.btn_Activiteiten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Activiteiten.Name = "btn_Activiteiten";
            this.btn_Activiteiten.Size = new System.Drawing.Size(120, 33);
            this.btn_Activiteiten.TabIndex = 7;
            this.btn_Activiteiten.Text = "Activiteiten";
            this.btn_Activiteiten.UseVisualStyleBackColor = true;
            this.btn_Activiteiten.Click += new System.EventHandler(this.btn_Activiteiten_Click);
            // 
            // btn_Mijn_Reseveringen
            // 
            this.btn_Mijn_Reseveringen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mijn_Reseveringen.Location = new System.Drawing.Point(670, 14);
            this.btn_Mijn_Reseveringen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Mijn_Reseveringen.Name = "btn_Mijn_Reseveringen";
            this.btn_Mijn_Reseveringen.Size = new System.Drawing.Size(189, 33);
            this.btn_Mijn_Reseveringen.TabIndex = 8;
            this.btn_Mijn_Reseveringen.Text = "Mijn Reseveringen";
            this.btn_Mijn_Reseveringen.UseVisualStyleBackColor = true;
            this.btn_Mijn_Reseveringen.Click += new System.EventHandler(this.btn_Mijn_Reseveringen_Click);
            // 
            // PushMelding
            // 
            this.PushMelding.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PushMelding.Location = new System.Drawing.Point(865, 14);
            this.PushMelding.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PushMelding.Name = "PushMelding";
            this.PushMelding.Size = new System.Drawing.Size(189, 54);
            this.PushMelding.TabIndex = 9;
            this.PushMelding.Text = "Push meldingen aan/uit zetten";
            this.PushMelding.UseVisualStyleBackColor = true;
            this.PushMelding.Click += new System.EventHandler(this.PushMelding_Click);
            // 
            // gMapControl
            // 
            this.gMapControl.Bearing = 0F;
            this.gMapControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gMapControl.CanDragMap = false;
            this.gMapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl.GrayScaleMode = false;
            this.gMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl.LevelsKeepInMemory = 5;
            this.gMapControl.Location = new System.Drawing.Point(24, 80);
            this.gMapControl.Margin = new System.Windows.Forms.Padding(4);
            this.gMapControl.MarkersEnabled = true;
            this.gMapControl.MaxZoom = 20;
            this.gMapControl.MinZoom = 1;
            this.gMapControl.MouseWheelZoomEnabled = true;
            this.gMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl.Name = "gMapControl";
            this.gMapControl.NegativeMode = false;
            this.gMapControl.PolygonsEnabled = true;
            this.gMapControl.RetryLoadTile = 0;
            this.gMapControl.RoutesEnabled = true;
            this.gMapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl.ShowTileGridLines = false;
            this.gMapControl.Size = new System.Drawing.Size(730, 475);
            this.gMapControl.TabIndex = 9;
            this.gMapControl.Zoom = 15D;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 561);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(445, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Geel = 5+ personen, Blauw = 10+ personen en Rood = 50+ personen";
            // 
            // Activteiten_datagrid
            // 
            this.Activteiten_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Activteiten_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naam,
            this.Locatie,
            this.Drukte});
            this.Activteiten_datagrid.Location = new System.Drawing.Point(777, 321);
            this.Activteiten_datagrid.Name = "Activteiten_datagrid";
            this.Activteiten_datagrid.RowHeadersWidth = 51;
            this.Activteiten_datagrid.RowTemplate.Height = 24;
            this.Activteiten_datagrid.Size = new System.Drawing.Size(277, 234);
            this.Activteiten_datagrid.TabIndex = 11;
            // 
            // Naam
            // 
            this.Naam.HeaderText = "Naam";
            this.Naam.MinimumWidth = 6;
            this.Naam.Name = "Naam";
            this.Naam.ReadOnly = true;
            this.Naam.Width = 125;
            // 
            // Locatie
            // 
            this.Locatie.HeaderText = "Locatie";
            this.Locatie.MinimumWidth = 6;
            this.Locatie.Name = "Locatie";
            this.Locatie.ReadOnly = true;
            this.Locatie.Width = 125;
            // 
            // Drukte
            // 
            this.Drukte.HeaderText = "Aantal Reseveringen";
            this.Drukte.MinimumWidth = 6;
            this.Drukte.Name = "Drukte";
            this.Drukte.ReadOnly = true;
            this.Drukte.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(773, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Vandaag tedoen in de stad";
            // 
            // AllUsers
            // 
            this.AllUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.AllUsers.Location = new System.Drawing.Point(865, 73);
            this.AllUsers.Name = "AllUsers";
            this.AllUsers.Size = new System.Drawing.Size(189, 54);
            this.AllUsers.TabIndex = 13;
            this.AllUsers.Text = "Gebruikers aanpassen";
            this.AllUsers.UseVisualStyleBackColor = true;
            this.AllUsers.Click += new System.EventHandler(this.AllUsers_Click);
            // 
            // MainBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 593);
            this.Controls.Add(this.AllUsers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Activteiten_datagrid);
            this.Controls.Add(this.PushMelding);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gMapControl);
            this.Controls.Add(this.btn_Mijn_Reseveringen);
            this.Controls.Add(this.btn_Activiteiten);
            this.Controls.Add(this.btn_Account);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_uitloggen);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainBase";
            this.Text = "MainBase";
            this.Load += new System.EventHandler(this.MainBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Activteiten_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_uitloggen;
        private System.Windows.Forms.Button btn_Account;
        private System.Windows.Forms.Button btn_Activiteiten;
        private System.Windows.Forms.Button btn_Mijn_Reseveringen;
        private System.Windows.Forms.Button PushMelding;
        private GMap.NET.WindowsForms.GMapControl gMapControl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Activteiten_datagrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Locatie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drukte;
        private System.Windows.Forms.Button AllUsers;
    }
}