namespace Pizza_Delivery
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonAdaugaComanda = new System.Windows.Forms.Button();
            this.buttonFinalizeazaComanda = new System.Windows.Forms.Button();
            this.labelSelecteaza = new System.Windows.Forms.Label();
            this.labelTopping = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkedListBoxTopping = new System.Windows.Forms.CheckedListBox();
            this.labelPret = new System.Windows.Forms.Label();
            this.textBoxPret = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonSterge = new System.Windows.Forms.Button();
            this.buttonRenunta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdaugaComanda
            // 
            this.buttonAdaugaComanda.BackColor = System.Drawing.Color.SeaShell;
            this.buttonAdaugaComanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdaugaComanda.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdaugaComanda.Location = new System.Drawing.Point(87, 449);
            this.buttonAdaugaComanda.Name = "buttonAdaugaComanda";
            this.buttonAdaugaComanda.Size = new System.Drawing.Size(186, 36);
            this.buttonAdaugaComanda.TabIndex = 1;
            this.buttonAdaugaComanda.Text = "Adauga Comanda";
            this.buttonAdaugaComanda.UseVisualStyleBackColor = false;
            this.buttonAdaugaComanda.Click += new System.EventHandler(this.buttonAdaugaComanda_Click);
            // 
            // buttonFinalizeazaComanda
            // 
            this.buttonFinalizeazaComanda.BackColor = System.Drawing.Color.SeaShell;
            this.buttonFinalizeazaComanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFinalizeazaComanda.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonFinalizeazaComanda.Location = new System.Drawing.Point(409, 449);
            this.buttonFinalizeazaComanda.Name = "buttonFinalizeazaComanda";
            this.buttonFinalizeazaComanda.Size = new System.Drawing.Size(161, 36);
            this.buttonFinalizeazaComanda.TabIndex = 2;
            this.buttonFinalizeazaComanda.Text = "Finalizeaza Comanda";
            this.buttonFinalizeazaComanda.UseVisualStyleBackColor = false;
            this.buttonFinalizeazaComanda.Click += new System.EventHandler(this.buttonFinalizeazaComanda_Click);
            // 
            // labelSelecteaza
            // 
            this.labelSelecteaza.AutoSize = true;
            this.labelSelecteaza.BackColor = System.Drawing.Color.DimGray;
            this.labelSelecteaza.Font = new System.Drawing.Font("Myriad Hebrew", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelecteaza.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelSelecteaza.Location = new System.Drawing.Point(69, 87);
            this.labelSelecteaza.Name = "labelSelecteaza";
            this.labelSelecteaza.Size = new System.Drawing.Size(288, 30);
            this.labelSelecteaza.TabIndex = 3;
            this.labelSelecteaza.Text = "Selecteaza Tipul de Pizza:";
            // 
            // labelTopping
            // 
            this.labelTopping.AutoSize = true;
            this.labelTopping.BackColor = System.Drawing.Color.DimGray;
            this.labelTopping.Font = new System.Drawing.Font("Myriad Hebrew", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTopping.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelTopping.Location = new System.Drawing.Point(69, 176);
            this.labelTopping.Name = "labelTopping";
            this.labelTopping.Size = new System.Drawing.Size(237, 30);
            this.labelTopping.TabIndex = 3;
            this.labelTopping.Text = "Alege Extra Topping:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Margherita",
            "Diavola",
            "Quattro Formaggi",
            "Carnivora",
            "Capricciosa",
            "Romana"});
            this.comboBox1.Location = new System.Drawing.Point(69, 138);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(269, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // checkedListBoxTopping
            // 
            this.checkedListBoxTopping.FormattingEnabled = true;
            this.checkedListBoxTopping.Items.AddRange(new object[] {
            "Bacon",
            "Ciuperci",
            "Masline",
            "Porumb",
            "Jalapeno"});
            this.checkedListBoxTopping.Location = new System.Drawing.Point(67, 223);
            this.checkedListBoxTopping.Name = "checkedListBoxTopping";
            this.checkedListBoxTopping.Size = new System.Drawing.Size(271, 106);
            this.checkedListBoxTopping.TabIndex = 5;
            // 
            // labelPret
            // 
            this.labelPret.AutoSize = true;
            this.labelPret.BackColor = System.Drawing.Color.DimGray;
            this.labelPret.Font = new System.Drawing.Font("Myriad Hebrew", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPret.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelPret.Location = new System.Drawing.Point(69, 355);
            this.labelPret.Name = "labelPret";
            this.labelPret.Size = new System.Drawing.Size(66, 30);
            this.labelPret.TabIndex = 3;
            this.labelPret.Text = "Pret:";
            // 
            // textBoxPret
            // 
            this.textBoxPret.Location = new System.Drawing.Point(155, 359);
            this.textBoxPret.Name = "textBoxPret";
            this.textBoxPret.ReadOnly = true;
            this.textBoxPret.Size = new System.Drawing.Size(157, 22);
            this.textBoxPret.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Info;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(376, 87);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(644, 294);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Produs";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Pret";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Extra Topping";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 170;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 130;
            // 
            // buttonSterge
            // 
            this.buttonSterge.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSterge.Location = new System.Drawing.Point(565, 387);
            this.buttonSterge.Name = "buttonSterge";
            this.buttonSterge.Size = new System.Drawing.Size(132, 30);
            this.buttonSterge.TabIndex = 8;
            this.buttonSterge.Text = "Sterge Produs";
            this.buttonSterge.UseVisualStyleBackColor = true;
            this.buttonSterge.Click += new System.EventHandler(this.buttonSterge_Click);
            // 
            // buttonRenunta
            // 
            this.buttonRenunta.BackColor = System.Drawing.Color.SeaShell;
            this.buttonRenunta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRenunta.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRenunta.Location = new System.Drawing.Point(706, 449);
            this.buttonRenunta.Name = "buttonRenunta";
            this.buttonRenunta.Size = new System.Drawing.Size(104, 36);
            this.buttonRenunta.TabIndex = 9;
            this.buttonRenunta.Text = "Renunta";
            this.buttonRenunta.UseVisualStyleBackColor = false;
            this.buttonRenunta.Click += new System.EventHandler(this.buttonRenunta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1032, 520);
            this.Controls.Add(this.buttonRenunta);
            this.Controls.Add(this.buttonSterge);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBoxPret);
            this.Controls.Add(this.checkedListBoxTopping);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelPret);
            this.Controls.Add(this.labelTopping);
            this.Controls.Add(this.labelSelecteaza);
            this.Controls.Add(this.buttonFinalizeazaComanda);
            this.Controls.Add(this.buttonAdaugaComanda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Selectia Produselor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAdaugaComanda;
        private System.Windows.Forms.Button buttonFinalizeazaComanda;
        private System.Windows.Forms.Label labelSelecteaza;
        private System.Windows.Forms.Label labelTopping;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckedListBox checkedListBoxTopping;
        private System.Windows.Forms.Label labelPret;
        private System.Windows.Forms.TextBox textBoxPret;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button buttonSterge;
        private System.Windows.Forms.Button buttonRenunta;
    }
}

